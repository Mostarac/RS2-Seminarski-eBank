using eBank.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Controllers
{
    public class RoleController : BaseController<Model.Role, object>
    {
        public RoleController(IService<Model.Role, object> service) : base(service)
        {

        }
    }
}
