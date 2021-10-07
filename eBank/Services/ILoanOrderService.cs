using eBank.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Services
{
    public interface ILoanOrderService
    {
        List<Model.LoanOrder> Get(LoanOrderSearchRequest request);
        Model.LoanOrder GetById(int id);
        Model.LoanOrder Insert(LoanOrderUpsertRequest request);
        Model.LoanOrder Update(int id, LoanOrderUpsertRequest request);
    }
}
