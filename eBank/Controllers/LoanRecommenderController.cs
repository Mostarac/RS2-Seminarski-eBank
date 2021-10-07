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
    public class LoanRecommenderController : ControllerBase
    {
        private readonly ILoanRecommenderService _service;
        public LoanRecommenderController(ILoanRecommenderService service)
        {
            _service = service;
        }

        [HttpGet]
        public Model.LoanRecommendation Get([FromQuery] LoanRecommendationRequest request)
        {

            return _service.Get(request);
        }
    }
}
