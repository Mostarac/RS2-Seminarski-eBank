using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBank.Model.Requests
{
    public class UserSearchRequest
    {
        public string Name { get; set; }

        [RegularExpression("^[0-9]{1,13}$", ErrorMessage ="If used for search, JMBG must contain 1-13 digits")]
        public string JMBG { get; set; }
        public string Username { get; set; }
        public bool IsUlogeLoadingEnabled { get; set; }
        public bool ClientsOnly { get; set; }
    }
}
