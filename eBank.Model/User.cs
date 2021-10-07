using System;
using System.Collections.Generic;
using System.Text;

namespace eBank.Model
{
    public class User
    {
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
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
