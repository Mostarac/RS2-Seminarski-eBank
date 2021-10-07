using eBank.Model.Requests;
using eBank.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LoanOrderController : ControllerBase
    {

        private readonly ILoanOrderService _service;
        public LoanOrderController(ILoanOrderService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.LoanOrder> Get([FromQuery] LoanOrderSearchRequest request)
        {

            //var loggedInUserId = HttpContext.User.Claims.First(x => x.Type == "name").Value;

            return _service.Get(request);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        public Model.LoanOrder Insert(LoanOrderUpsertRequest request)
        {
            return _service.Insert(request);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public Model.LoanOrder Update(int id, [FromBody] LoanOrderUpsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.LoanOrder GetById(int id)
        {
            return _service.GetById(id);
        }

    }
}
