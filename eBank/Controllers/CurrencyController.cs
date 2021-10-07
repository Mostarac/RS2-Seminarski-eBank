using eBank.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Controllers
{
    public class CurrencyController : BaseController<Model.Currency, object>
    {
        public CurrencyController(IService<Model.Currency, object> service) : base(service)
        {

        }
    }
}
