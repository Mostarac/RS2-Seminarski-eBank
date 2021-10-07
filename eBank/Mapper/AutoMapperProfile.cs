using AutoMapper;
using eBank.Model;
using eBank.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Database.Loan, Model.Loan>();
            CreateMap<Database.Loan, Model.Requests.LoanUpsertRequest>().ReverseMap();
            CreateMap<Database.User, Model.Requests.UserUpsertRequest>().ReverseMap();
            CreateMap<Database.User, Model.User>(); 
            CreateMap<Database.City, Model.City>();
            CreateMap<Database.Role, Model.Role>();
            CreateMap<Database.UserRole, Model.UserRole>();
            CreateMap<Database.Account, Model.Account>();
            CreateMap<Database.AccountNumber, Model.AccountNumber>();
            CreateMap<Database.AccountType, Model.AccountType>();
            CreateMap<Database.Currency, Model.Currency>();
            CreateMap<Database.Account, Model.Requests.AccountUpsertRequest>().ReverseMap();
            CreateMap<Database.Transaction, Model.Transaction>();
            CreateMap<Database.LoanOrder, Model.LoanOrder>();
            CreateMap<Database.LoanOrder, Model.Requests.LoanOrderUpsertRequest>().ReverseMap();
            CreateMap<Database.LoanOrderTransaction, Model.LoanOrderTransaction>();
            CreateMap<Database.LoanOrderTransaction, Model.Requests.LoanOrderTransactionUpsertRequest>().ReverseMap();
        }

    }
}
