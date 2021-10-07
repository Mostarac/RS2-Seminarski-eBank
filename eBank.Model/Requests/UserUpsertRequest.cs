using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBank.Model.Requests
{
    public class UserUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public int CityId { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public string Username { get; set; }

        public string Password { get; set; }

        [Required]
        public string JMBG { get; set; }
        public List<int> Roles { get; set; } = new List<int>();

        public byte[] Image { get; set; }
    }
}
