using eBank.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Services
{
    public interface IAccountService
    {
        //List<Model.Account> GetListByJMBG(string JMBG);
        List<Model.Account> Get(AccountSearchRequest request);
        Model.Account GetById(int id);
        Model.Account Insert(AccountUpsertRequest request);
        Model.Account Update(int id, AccountUpsertRequest request);
    }
}
