using eBank.WebAPI.Helper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace eBank.WebAPI.Database
{
    public partial class eBankContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            
            List<string> Salt = new List<string>();
            for (int i = 0; i < 12; i++)
            {
                Salt.Add(HashHelper.GenerateSalt());
            }

            modelBuilder.Entity<City>()
                .HasData
                (
                    new City 
                    { 
                        CityId = 1, 
                        Name = "Mostar"
                    },
                    new City
                    {
                        CityId = 2,
                        Name = "Sarajevo"
                    },
                    new City
                    {
                        CityId = 3,
                        Name = "Tuzla"
                    },
                    new City
                    {
                        CityId = 4,
                        Name = "Doboj"
                    },
                    new City
                    {
                        CityId = 5,
                        Name = "Cazin"
                    }
                );

            modelBuilder.Entity<Currency>()
                .HasData
                (
                    new Currency
                    {
                        CurrencyId = "BAM",
                        Symbol = "KM",
                        Name = "Bosnian convertible mark"
                    },
                    new Currency
                    {
                        CurrencyId = "EUR",
                        Symbol = "€",
                        Name = "Euro"
                    },
                    new Currency
                    {
                        CurrencyId = "USD",
                        Symbol = "$",
                        Name = "United States dollar"
                    }
                );

            modelBuilder.Entity<CurrencyPair>()
                .HasData
                (
                    new CurrencyPair
                    {
                        CurrencyPairId = 1,
                        FirstId = "EUR",
                        SecondId = "BAM",
                        RatioFirstSecond = 1.95
                    },
                    new CurrencyPair
                    {
                        CurrencyPairId = 2,
                        FirstId = "EUR",
                        SecondId = "USD",
                        RatioFirstSecond = 1.22
                    },
                    new CurrencyPair
                    {
                        CurrencyPairId = 3,
                        FirstId = "USD",
                        SecondId = "BAM",
                        RatioFirstSecond = 1.6
                    }
                );

            modelBuilder.Entity<User>()
                .HasData
                (
                    new User
                    {
                        UserId = 1,
                        FirstName = "Administrator",
                        LastName = "One",
                        Username = "Administrator",
                        Email = "administrator.one@ebank.com",
                        Image = FileHelper.ReadFile("./SeedFiles/Images/Users/profile-picture.png"),
                        PasswordSalt = Salt[0],
                        PasswordHash = HashHelper.GenerateHash(Salt[0], "test"),
                        CityId = 1,
                        Address = "Mostarska 1",
                        DateOfBirth = System.DateTime.Parse("05.05.1990"),
                        JMBG = "1234567891234",
                        Gender = Gender.Male
                    },
                    new User
                    {
                        UserId = 2,
                        FirstName = "Employee",
                        LastName = "One",
                        Username = "Employee",
                        Email = "employee.one@ebank.com",
                        Image = FileHelper.ReadFile("./SeedFiles/Images/Users/profile-picture.png"),
                        PasswordSalt = Salt[1],
                        PasswordHash = HashHelper.GenerateHash(Salt[1], "test"),
                        CityId = 2,
                        Address = "Sarajevska 2",
                        DateOfBirth = System.DateTime.Parse("05.05.1985"),
                        JMBG = "2345678912345",
                        Gender = Gender.Female
                    },
                    new User
                    {
                        UserId = 3,
                        FirstName = "Client",
                        LastName = "One",
                        Username = "Client",
                        Email = "client.one@ebank.com",
                        Image = FileHelper.ReadFile("./SeedFiles/Images/Users/profile-picture.png"),
                        PasswordSalt = Salt[2],
                        PasswordHash = HashHelper.GenerateHash(Salt[2], "test"),
                        CityId = 1,
                        Address = "Mostarska 1",
                        DateOfBirth = System.DateTime.Parse("05.05.1985"),
                        JMBG = "3456789123456",
                        Gender = Gender.Male
                    },
                    new User
                    {
                        UserId = 4,
                        FirstName = "Client",
                        LastName = "Two",
                        Username = "Client2",
                        Email = "client.two@ebank.com",
                        Image = FileHelper.ReadFile("./SeedFiles/Images/Users/profile-picture.png"),
                        PasswordSalt = Salt[3],
                        PasswordHash = HashHelper.GenerateHash(Salt[2], "test"),
                        CityId = 1,
                        Address = "Mostarska 1",
                        DateOfBirth = System.DateTime.Parse("05.05.1985"),
                        JMBG = "4567891234567",
                        Gender = Gender.Male
                    },
                    new User
                    {
                        UserId = 5,
                        FirstName = "Client",
                        LastName = "Three",
                        Username = "Client3",
                        Email = "user2@ebank.com",
                        Image = FileHelper.ReadFile("./SeedFiles/Images/Users/profile-picture.png"),
                        PasswordSalt = Salt[4],
                        PasswordHash = HashHelper.GenerateHash(Salt[4], "test"),
                        CityId = 2,
                        Address = "Sarajevska 3",
                        DateOfBirth = System.DateTime.Parse("05.05.1985"),
                        JMBG = "5678912345678",
                        Gender = Gender.Male
                    },
                    new User
                    {
                        UserId = 6,
                        FirstName = "Client",
                        LastName = "Four",
                        Username = "Client4",
                        Email = "client.four@ebank.com",
                        Image = FileHelper.ReadFile("./SeedFiles/Images/Users/profile-picture.png"),
                        PasswordSalt = Salt[5],
                        PasswordHash = HashHelper.GenerateHash(Salt[5], "test"),
                        CityId = 2,
                        Address = "Sarajevska 4",
                        DateOfBirth = System.DateTime.Parse("05.05.1985"),
                        JMBG = "6789123456789",
                        Gender = Gender.Male
                    },
                    new User
                    {
                        UserId = 7,
                        FirstName = "Client",
                        LastName = "Five",
                        Username = "Client5",
                        Email = "client.five@ebank.com",
                        Image = FileHelper.ReadFile("./SeedFiles/Images/Users/profile-picture.png"),
                        PasswordSalt = Salt[6],
                        PasswordHash = HashHelper.GenerateHash(Salt[6], "test"),
                        CityId = 3,
                        Address = "Tuzlanska 5",
                        DateOfBirth = System.DateTime.Parse("05.05.1985"),
                        JMBG = "7891234567891",
                        Gender = Gender.Male
                    },
                    new User
                    {
                        UserId = 8,
                        FirstName = "Client",
                        LastName = "Six",
                        Username = "Client6",
                        Email = "client.six@ebank.com",
                        Image = FileHelper.ReadFile("./SeedFiles/Images/Users/profile-picture.png"),
                        PasswordSalt = Salt[7],
                        PasswordHash = HashHelper.GenerateHash(Salt[7], "test"),
                        CityId = 3,
                        Address = "Tuzlanska 6",
                        DateOfBirth = System.DateTime.Parse("05.05.1985"),
                        JMBG = "8912345678912",
                        Gender = Gender.Female
                    },
                    new User
                    {
                        UserId = 9,
                        FirstName = "Client",
                        LastName = "Seven",
                        Username = "Client7",
                        Email = "client.seven@ebank.com",
                        Image = FileHelper.ReadFile("./SeedFiles/Images/Users/profile-picture.png"),
                        PasswordSalt = Salt[8],
                        PasswordHash = HashHelper.GenerateHash(Salt[8], "test"),
                        CityId = 4,
                        Address = "Dobojska 7",
                        DateOfBirth = System.DateTime.Parse("05.05.1985"),
                        JMBG = "9123456789123",
                        Gender = Gender.Female
                    },
                    new User
                    {
                        UserId = 10,
                        FirstName = "Client",
                        LastName = "Eight",
                        Username = "Client8",
                        Email = "client.eight@ebank.com",
                        Image = FileHelper.ReadFile("./SeedFiles/Images/Users/profile-picture.png"),
                        PasswordSalt = Salt[9],
                        PasswordHash = HashHelper.GenerateHash(Salt[9], "test"),
                        CityId = 4,
                        Address = "Dobojska 8",
                        DateOfBirth = System.DateTime.Parse("05.05.1985"),
                        JMBG = "9876543219876",
                        Gender = Gender.Female
                    },
                    new User
                    {
                        UserId = 11,
                        FirstName = "Client",
                        LastName = "Nine",
                        Username = "Client9",
                        Email = "client.nine@ebank.com",
                        Image = FileHelper.ReadFile("./SeedFiles/Images/Users/profile-picture.png"),
                        PasswordSalt = Salt[10],
                        PasswordHash = HashHelper.GenerateHash(Salt[9], "test"),
                        CityId = 5,
                        Address = "Cazinska 9",
                        DateOfBirth = System.DateTime.Parse("05.05.1985"),
                        JMBG = "8765432198765",
                        Gender = Gender.Female
                    },
                    new User
                    {
                        UserId = 12,
                        FirstName = "Client",
                        LastName = "Client10",
                        Username = "Client10",
                        Email = "client.ten@ebank.com",
                        Image = FileHelper.ReadFile("./SeedFiles/Images/Users/profile-picture.png"),
                        PasswordSalt = Salt[11],
                        PasswordHash = HashHelper.GenerateHash(Salt[9], "test"),
                        CityId = 5,
                        Address = "Cazinska 10",
                        DateOfBirth = System.DateTime.Parse("05.05.1985"),
                        JMBG = "7654321987654",
                        Gender = Gender.Female
                    }
                );


            modelBuilder.Entity<Role>()
                .HasData
                (
                    new Role { RoleId = 1, Name = "Administrator", Description = "Administrator role for the system, will be used on desktop client" },
                    new Role { RoleId = 2, Name = "Employee", Description = "Employee role for the system, will be used on desktop client" },
                    new Role { RoleId = 3, Name = "Client", Description = "Client role for the system, will be used on mobile client" }
                );

            modelBuilder.Entity<UserRole>()
                .HasData
                (
                    new UserRole { UserRoleId = 1, UserId = 1, RoleId = 1 },
                    new UserRole { UserRoleId = 2, UserId = 2, RoleId = 2 },
                    new UserRole { UserRoleId = 3, UserId = 3, RoleId = 3 },
                    new UserRole { UserRoleId = 4, UserId = 4, RoleId = 3 },
                    new UserRole { UserRoleId = 5, UserId = 5, RoleId = 3 },
                    new UserRole { UserRoleId = 6, UserId = 6, RoleId = 3 },
                    new UserRole { UserRoleId = 7, UserId = 7, RoleId = 3 },
                    new UserRole { UserRoleId = 8, UserId = 8, RoleId = 3 },
                    new UserRole { UserRoleId = 9, UserId = 9, RoleId = 3 },
                    new UserRole { UserRoleId = 10, UserId = 10, RoleId = 3 },
                    new UserRole { UserRoleId = 11, UserId = 11, RoleId = 3 },
                    new UserRole { UserRoleId = 12, UserId = 12, RoleId = 3 }
                );

            modelBuilder.Entity<AccountType>()
                .HasData
                (
                    new AccountType { AccountTypeId = 1, Name = "Liquid" },
                    new AccountType { AccountTypeId = 2, Name = "Debit" },
                    new AccountType { AccountTypeId = 3, Name = "Deposit" },
                    new AccountType { AccountTypeId = 4, Name = "Loan capital" }
                );

            modelBuilder.Entity<AccountNumber>()
                .HasData
                (

                    new AccountNumber { AccountNumberId = 1, Number = "1550000000000001" },
                    new AccountNumber { AccountNumberId = 2, Number = "1554285505152213" },
                    new AccountNumber { AccountNumberId = 3, Number = "1555558851214500" }

                );

            modelBuilder.Entity<Account>()
                .HasData
                (
                    new Account
                    {
                        AccountId = 1,
                        AccountNumberId = 1,
                        AccountTypeId = 4,
                        CurrencyId = "EUR",
                        Balance = 999999999999999,
                        Limit = 2000,
                        UserId = 1
                    },
                    new Account
                    {
                        AccountId = 2,
                        AccountNumberId = 2,
                        AccountTypeId = 3,
                        CurrencyId = "EUR",
                        Balance = 20000,
                        Limit = 2000,
                        UserId = 3
                    },
                    new Account
                    {
                        AccountId = 3,
                        AccountNumberId = 3,
                        AccountTypeId = 2,
                        CurrencyId = "USD",
                        Balance = 10000,
                        Limit = 2000,
                        UserId = 3
                    }
                );

            modelBuilder.Entity<Loan>()
                .HasData
                (
                    new Loan 
                    { 
                        LoanId = 1,
                        Name = "Home loan",
                        EIR = 3,
                        Limit = 5000000,
                        LenderId = 1,
                        MinPayments = 12,
                        MaxPayments = 360,
                    },
                    new Loan
                    {
                        LoanId = 2,
                        Name = "Personal loan",
                        EIR = 7,
                        Limit = 500000,
                        LenderId = 1,
                        MinPayments = 3,
                        MaxPayments = 60,
                    },
                    new Loan
                    {
                        LoanId = 3,
                        Name = "Student loan",
                        EIR = 5,
                        Limit = 200000,
                        LenderId = 1,
                        MinPayments = 6,
                        MaxPayments = 120,
                    }
                );


            modelBuilder.Entity<LoanOrder>()
                .HasData
                (
                    new LoanOrder
                    {
                        LoanOrderId = 1,
                        LoanId = 1,
                        AccountId = 2,
                        Amount = 10000,
                        Months = 24,
                        Comment = null,
                        LoanOrderState = LoanOrderState.Ordered,
                        CreationDate = System.DateTime.Parse("06.04.2021"),
                    }
                );

            modelBuilder.Entity<LoanOrder>()
                .HasData
                (
                    new LoanOrder
                    {
                        LoanOrderId = 2,
                        LoanId = 1,
                        AccountId = 2,
                        Amount = 10000,
                        Months = 24,
                        Comment = null,
                        LoanOrderState = LoanOrderState.Denied,
                        CreationDate = System.DateTime.Parse("06.04.2021"),
                    }
                );

            modelBuilder.Entity<LoanOrder>()
                .HasData
                (
                    new LoanOrder
                    {
                        LoanOrderId = 3,
                        LoanId = 1,
                        AccountId = 2,
                        Amount = 10000,
                        Months = 24,
                        Comment = null,
                        LoanOrderState = LoanOrderState.Active,
                        CreationDate = System.DateTime.Parse("06.04.2021"),
                    }
                );

            modelBuilder.Entity<LoanOrder>()
                .HasData
                (
                    new LoanOrder
                    {
                        LoanOrderId = 4,
                        LoanId = 1,
                        AccountId = 2,
                        Amount = 10000,
                        Months = 24,
                        Comment = null,
                        LoanOrderState = LoanOrderState.Finished,
                        CreationDate = System.DateTime.Parse("06.04.2021"),
                    }
                );

            /*
            modelBuilder.Entity<Transaction>()
                .HasData
                (
                    new Transaction 
                    {
                        TransactionId = 1,
                        RecipientId = 2,
                        SenderId = 1,
                        CurrencyId = "EUR",
                        Amount = 100,
                        CounterAmount = 122,
                        Date = System.DateTime.Parse("06.04.2021"),
                        Description = "For help"
                    },
                    new Transaction
                    {
                        TransactionId = 2,
                        RecipientId = 1,
                        SenderId = 2,
                        CurrencyId = "USD",
                        Amount = 122,
                        CounterAmount = 100,
                        Date = System.DateTime.Parse("06.04.2021"),
                        Description = "A gift"
                    }
                );

            
            */

        }
    }
}