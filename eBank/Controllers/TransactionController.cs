using eBank.Model.Requests;
using eBank.WebAPI.Exceptions;
using eBank.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eBank.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _service;
        public TransactionController(ITransactionService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Transaction> Get([FromQuery] TransactionSearchRequest request)
        {

            //var loggyuserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //var loggedUsername = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            return _service.Get(request);
        }

        [HttpPost]
        public Model.Transaction Insert(TransactionInsertRequest request)
        {
            return _service.Insert(request);
        }

    }
}
