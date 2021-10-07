using AutoMapper;
using eBank.Model.Requests;
using eBank.WebAPI.Database;
using eBank.WebAPI.Exceptions;
using eBank.WebAPI.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eBank.WebAPI.Services
{
    public class UserService : IUserService
    {
        private readonly eBankContext _context;
        private readonly IMapper _mapper;
        public UserService(eBankContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Model.User> Authenticate(UserAuthenticationRequest request)
        {
            var user = await _context.User
                .Include(x => x.UserRoles)
                .ThenInclude(y => y.Role)
                .FirstOrDefaultAsync(i => i.Username == request.Username);

            if (user != null)
            {
                var hash = HashHelper.GenerateHash(user.PasswordSalt, request.Password);
                if (hash == user.PasswordHash)
                {
                    return _mapper.Map<Model.User>(user);
                }
            }

            return null;
        }

        public List<Model.User> Get(UserSearchRequest request)
        {
            var query = _context.User.AsQueryable();

            if (request?.ClientsOnly == true)
            {
                var clientRole = _context.Role.Where(x => x.Name == "Client").First();
                request.IsUlogeLoadingEnabled = false;
                //query = query.Where(x => x.UserRoles.);
                query = _context.UserRole.Include(x => x.User).Include(x => x.User.UserRoles).ThenInclude(x=>x.Role).Include(x => x.User.City).Where(x => x.RoleId == clientRole.RoleId).Select(x => x.User);
                
            }

            if (!string.IsNullOrWhiteSpace(request?.Name))
            {
                query = query.Where(x => (x.FirstName + " " + x.LastName).Contains(request.Name));
            }

            if (!string.IsNullOrWhiteSpace(request?.Username))
            {
                query = query.Where(x => x.Username == request.Username);
            }

            if (!string.IsNullOrWhiteSpace(request?.JMBG))
            {
                query = query.Where(x => x.JMBG.Contains(request.JMBG));
            }

            if (request?.IsUlogeLoadingEnabled == true)
            {
                query = query.Include(x => x.UserRoles);
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.User>>(list);
        }

        public Model.User GetById(int id)
        {
            var entity = _context.User.Include(x=>x.UserRoles).ThenInclude(x=>x.Role).Single(x=>x.UserId==id);

            return _mapper.Map<Model.User>(entity);
        }

        public Model.User Insert(UserUpsertRequest request)
        {
            if (request.Roles.Count() == 0)
            {
                throw new UserException("User role list must not be empty");
            }

            if(string.IsNullOrEmpty(request.Password))
            {
                throw new UserException("Password must not be empty");
            }

            if(string.IsNullOrWhiteSpace(request.Password))
            {
                throw new UserException("Password must not be empty");
            }

            if (request.Password.Length < 4)
            {
                throw new UserException("Password not long enough!");
            }

            var entity = _mapper.Map<Database.User>(request);

            entity.PasswordSalt = HashHelper.GenerateSalt();
            entity.PasswordHash = HashHelper.GenerateHash(entity.PasswordSalt, request.Password);

            _context.User.Add(entity);
            _context.SaveChanges();

            foreach (var role in request.Roles)
            {
                Database.UserRole userRoles = new Database.UserRole();
                userRoles.UserId = entity.UserId;
                userRoles.RoleId = role;
                _context.UserRole.Add(userRoles);
            }
            _context.SaveChanges();

            return _mapper.Map<Model.User>(entity);
        }

        public Model.User Update(int id, UserUpsertRequest request)
        {
            if (request.Roles.Count() == 0)
            {
                throw new UserException("User role list must not be empty");
            }

            var entity = _context.User.Find(id);

            if (!string.IsNullOrWhiteSpace(request.Password) || !string.IsNullOrEmpty(request.Password))
            {
                if (request.Password.Length < 4)
                {
                    throw new UserException("Password not long enough!");
                }
                entity.PasswordSalt = HashHelper.GenerateSalt();
                entity.PasswordHash = HashHelper.GenerateHash(entity.PasswordSalt, request.Password);
            }

            
            _context.User.Attach(entity);
            _context.User.Update(entity);

            //Get list of all user's existing roles, it can't be empty since adding empty is disallowed
            var existingRoles = _context.UserRole.Where(x => x.UserId == id).ToList();
            //Make an int version of it, to be used later for role-removing
            List<int> existingRolesInt = existingRoles.Select(x => x.RoleId).ToList();

            foreach (var role in request.Roles)
            {

                var existingRole = existingRoles.SingleOrDefault(x => x.RoleId == role);
                if (existingRole == null)
                {
                    //If role isn't in list of user's existing roles, add it
                    Database.UserRole userRole = new Database.UserRole();
                    userRole.UserId = entity.UserId;
                    userRole.RoleId = role;
                    _context.UserRole.Add(userRole);
                    existingRolesInt.Add(role);
                    existingRoles.Add(userRole);
                }

            }

            _context.SaveChanges();

            //Now we have to check if any roles should be removed, if any from existing roles aren't contained in request's list

            foreach(var existingRoleInt in existingRolesInt)
            {
                bool found = false;
                foreach(var role in request.Roles)
                {
                    if (existingRoleInt == role)
                    {
                        found = true;
                    }
                }

                if(!found)
                {
                    _context.UserRole.Remove(existingRoles.Single(x=>x.RoleId==existingRoleInt));
                }
                
            }

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.User>(entity);
        }
    }
}
