using AutoMapper;
using eBank.Model.Requests;
using eBank.WebAPI.Database;
using eBank.WebAPI.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Services
{
    public class AccountService : IAccountService
    {
        private readonly eBankContext _context;
        private readonly IMapper _mapper;
        public AccountService(eBankContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Account> Get(AccountSearchRequest search)
        {

            var list = _context.Account.Include(x=>x.AccountNumber).Include(x=>x.Currency).Include(x=>x.AccountType).Include(x => x.User).Where(x => x.User.UserId == search.UserId).ToList();

            return _mapper.Map<List<Model.Account>>(list);
        }

        public Model.Account GetById(int id)
        {
            var entity = _context.Account.Include(x=>x.Currency).Include(x=>x.User).Include(x=>x.AccountNumber).Where(x=>x.AccountId == id).SingleOrDefault();

            if(entity==null)
            {
                throw new UserException("Account with specified id not found!");
            }

            return _mapper.Map<Model.Account>(entity);
        }

        public Model.Account Insert(AccountUpsertRequest request)
        {

            var entity = _mapper.Map<Database.Account>(request);

            //For each new account we have to create random 16-digit AccountNumber first

            //number pool for random number
            string pool = "0123456789";

            //first 3 numbers are unique for this bank
            string output = "155";

            Random r = new Random();
            bool invalid;

            do
            {
                invalid = false;
                output = "155";

                for (int i = 0; i < 13; i++)
                {
                    output += pool[r.Next(0, 9)];
                }

                if (_context.AccountNumber.Where(x => x.Number == output).SingleOrDefault() != null)
                {
                    invalid = true;
                }

            } while (invalid);

            AccountNumber accN = new AccountNumber { Number = output };
            _context.AccountNumber.Add(accN);

            entity.AccountNumberId = accN.AccountNumberId;
            entity.AccountNumber = accN;

            _context.Account.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Account>(entity);
        }

        public Model.Account Update(int id, AccountUpsertRequest request)
        {
            var entity = _context.Account.Find(id);
            _context.Account.Attach(entity);
            _context.Account.Update(entity);
            _mapper.Map(request, entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Account>(entity);
        }
        
    }
}
