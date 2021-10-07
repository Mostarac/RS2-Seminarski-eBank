using eBank.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Services
{
    public interface ILoanOrderTransactionService
    {
        //List<Model.Account> Get(AccountSearchRequest request);
        //Model.Account GetById(int id);
        Model.LoanOrderTransaction Insert(LoanOrderTransactionUpsertRequest request);
        //Model.Account Update(int id, AccountUpsertRequest request);
    }
}
