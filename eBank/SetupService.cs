using eBank.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI
{
    public class SetupService
    {
        public static void Init(eBankContext context)
        {
            context.Database.Migrate();
        }
    }
}
