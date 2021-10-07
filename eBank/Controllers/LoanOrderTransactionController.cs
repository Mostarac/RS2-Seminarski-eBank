using eBank.Model.Requests;
using eBank.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanOrderTransactionController : ControllerBase
    {
        private readonly ILoanOrderTransactionService _service;

        public LoanOrderTransactionController(ILoanOrderTransactionService service)
        {
            _service = service;
        }

        /*[HttpGet]
        public List<Model.Account> Get([FromQuery] AccountSearchRequest request)
        {

            //var loggedInUserId = HttpContext.User.Claims.First(x => x.Type == "name").Value;

            return _service.Get(request);
        }
        */

        [HttpPost]
        public Model.LoanOrderTransaction Insert(LoanOrderTransactionUpsertRequest request)
        {
            return _service.Insert(request);
        }

    }
}
