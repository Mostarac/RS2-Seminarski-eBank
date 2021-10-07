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
    public class AccountController : ControllerBase
    {

        private readonly IAccountService _service;
        public AccountController(IAccountService service)
        {
            _service = service;
        }

        /*
        [HttpGet]
        public List<Model.Account> GetListByJMBG([FromQuery] string JMBG)
        {
            return _service.GetListByJMBG(JMBG);
        }*/

        [HttpGet]
        public List<Model.Account> Get([FromQuery] AccountSearchRequest request)
        {

            //var loggedInUserId = HttpContext.User.Claims.First(x => x.Type == "name").Value;

            return _service.Get(request);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        public Model.Account Insert(AccountUpsertRequest request)
        {
            return _service.Insert(request);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public Model.Account Update(int id, [FromBody] AccountUpsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Account GetById(int id)
        {
            return _service.GetById(id);
        }

    }
}
