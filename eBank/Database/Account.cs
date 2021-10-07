using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eBank.WebAPI.Database
{
    [Index(nameof(AccountNumberId), IsUnique = true)]
    public class Account
    {
        public int AccountId { get; set; }
        public int AccountNumberId { get; set; }
        public AccountNumber AccountNumber { get; set; }
        public int AccountTypeId { get; set; }
        public AccountType AccountType { get; set; }
        public string CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public double Balance { get; set; }
        public double Limit { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
