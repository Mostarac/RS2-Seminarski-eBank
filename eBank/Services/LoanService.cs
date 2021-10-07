using AutoMapper;
using eBank.Model.Requests;
using eBank.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBank.Model;
using Microsoft.EntityFrameworkCore;
using eBank.WebAPI.Exceptions;

namespace eBank.WebAPI.Services
{
    public class LoanService : BaseCRUDService<Model.Loan, LoanSearchRequest, WebAPI.Database.Loan, LoanUpsertRequest, LoanUpsertRequest>
    {
        public LoanService(eBankContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Loan> Get(LoanSearchRequest search)
        {
            var query = _context.Set<WebAPI.Database.Loan> ().AsQueryable();

            query = query.Include(x=>x.Lender).Include(x => x.Lender.Currency);

            if (!string.IsNullOrWhiteSpace(search?.Name))
            {
                query = query.Where(x => x.Name.StartsWith(search.Name));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Loan>>(list);
        }

        public override Model.Loan GetById(int id)
        {
            var entity = _context.Loan.Include(x => x.Lender).Where(x => x.LoanId == id).SingleOrDefault();

            if(entity == null)
            {
                throw new UserException("Loan with specified id not found!");
            }

            return _mapper.Map<Model.Loan>(entity);
        }

    }
}
