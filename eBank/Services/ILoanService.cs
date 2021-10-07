using eBank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Services
{
    public interface ILoanService
    {
        List<Loan> Get();
        Loan GetById(int id);
    }
}
