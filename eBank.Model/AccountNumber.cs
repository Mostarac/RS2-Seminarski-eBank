using System;
using System.Collections.Generic;
using System.Text;

namespace eBank.Model
{
    public class AccountNumber
    {
        public int AccountNumberId { get; set; }
        public string Number { get; set; }
        public Account Account { get; set; }
    }
}
