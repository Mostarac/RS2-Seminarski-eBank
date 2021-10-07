using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Database
{
    public class User
    {

        public User()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public string Username { get; set; }
        public string JMBG { get; set; }
        public byte[] Image { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }

    }
}
