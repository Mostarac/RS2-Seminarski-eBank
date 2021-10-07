using eBank.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Services
{
    public interface ITransactionService
    {
        List<Model.Transaction> Get(TransactionSearchRequest search);
        Model.Transaction Insert(TransactionInsertRequest request);
    }
}
