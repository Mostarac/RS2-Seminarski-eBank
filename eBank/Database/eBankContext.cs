using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Database
{
    public partial class eBankContext : DbContext 
    {
        public eBankContext(DbContextOptions<eBankContext> options)
            : base(options)
        {
        }

        public DbSet<Loan> Loan { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }

        public DbSet<Role> Role { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<AccountNumber> AccountNumber { get; set; }
        public DbSet<AccountType> AccountType { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<CurrencyPair> CurrencyPair { get; set; }
        public DbSet<LoanOrder> LoanOrder { get; set; }
        public DbSet<LoanOrderTransaction> LoanOrderTransaction { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<AccountNumber>()
                .HasIndex(u => u.Number)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.JMBG)
                .IsUnique();

            modelBuilder
                .Entity<User>()
                .Property(e => e.Gender)
                .HasConversion<string>();

            modelBuilder
                .Entity<LoanOrder>()
                .Property(e => e.LoanOrderState)
                .HasConversion<string>();

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
