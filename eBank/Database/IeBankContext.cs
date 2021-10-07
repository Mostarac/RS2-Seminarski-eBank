using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Database
{
    public interface IeBankContext
    {
        DbSet<Loan> Loan { get; set; }
        DbSet<User> User { get; set; }
        DbSet<UserRole> UserRole { get; set; }
        DbSet<Role> Role { get; set; }
        DbSet<City> City { get; set; }
        DbSet<Account> Account { get; set; }
        DbSet<AccountNumber> AccountNumber { get; set; }
        DbSet<AccountType> AccountType { get; set; }
        DbSet<Currency> Currency { get; set; }
        DbSet<Transaction> Transaction { get; set; }
        DbSet<CurrencyPair> CurrencyPair { get; set; }
        DbSet<LoanOrder> LoanOrder { get; set; }
        DbSet<LoanOrderTransaction> LoanOrderTransaction { get; set; }

    }
}
