using AutoMapper;
using eBank.WebAPI.Database;
using eBank.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Controllers
{
    public class CityController : BaseController<Model.City, object>
    {
        public CityController(IService<Model.City, object> service) : base(service)
        {
            
        }
    }
}
