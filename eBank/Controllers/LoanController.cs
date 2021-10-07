using eBank.Model.Requests;
using eBank.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Controllers
{
    public class LoanController : BaseCRUDController<Model.Loan, LoanSearchRequest, LoanUpsertRequest, LoanUpsertRequest>
    {
        public LoanController(ICRUDService<Model.Loan, LoanSearchRequest, LoanUpsertRequest, LoanUpsertRequest> service) : base(service)
        {
        }
    }
}
