using eBank.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Controllers
{
    public class AccountTypeController : BaseController<Model.AccountType, object>
    {
        public AccountTypeController(IService<Model.AccountType, object> service) : base(service)
        {

        }
    }
}
