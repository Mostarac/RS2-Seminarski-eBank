using AutoMapper;
using eBank.Model.Requests;
using eBank.WebAPI.Database;
using eBank.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Services
{
    public class LoanOrderTransactionService : ILoanOrderTransactionService
    {
        private readonly eBankContext _context;
        private readonly IMapper _mapper;
        public LoanOrderTransactionService(eBankContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /*public List<Model.Account> Get(LoanOrderTransactionSearchRequest search)
        {

            var entity = _context.LoanOrderTransaction.Include(x => x.Transaction).Include(x => x.Transaction.Recipient).Include(x => x.Transaction.Recipient.Account).Include(x => x.Transaction.Recipient.Account.Currency).Include(x => x.Transaction.Sender).Include(x => x.Transaction.Sender.Account).Include(x => x.Transaction.Sender.Account.Currency).AsQueryable();

            if (search.LoanOrderId.HasValue)
            {
                entity = entity.Where(x => x.LoanOrderId == search.LoanOrderId).Select(x => x.Transaction);
            }

            var list = entity.ToList();
            return _mapper.Map<List<Model.Account>>(list);
        }*/

        /*public Model.Account GetById(int id)
        {
            var entity = _context.Account.Find(id);

            return _mapper.Map<Model.Account>(entity);
        }*/

        public Model.LoanOrderTransaction Insert(LoanOrderTransactionUpsertRequest request)
        {

            //Cant make new transactions if loan order state is finished
            var loanOrder = _context.LoanOrder.Include(x=>x.Loan).Where(x => x.LoanOrderId == request.LoanOrderId).SingleOrDefault();
            if (loanOrder.LoanOrderState != LoanOrderState.Active)
            {
                throw new UserException("Transactions can be inserted only for active loan orders");
            }

            //We need to set loan order state to FINISHED if client has paid off full amount of loan

            double A; //monthly payment rate amount
            double P = loanOrder.Amount; //loan amount
            int N = loanOrder.Months; //number of months
            double r = loanOrder.Loan.EIR / 100 / 12; //total effective rate amount per period (month)

            A = P * (r * Math.Pow(1 + r, N)) / (Math.Pow(1 + r, N) - 1);

            double Total = A * N;

            var entity = _mapper.Map<Database.LoanOrderTransaction>(request);

            _context.LoanOrderTransaction.Add(entity);
            _context.SaveChanges();

            var TotalPaid = _context.LoanOrderTransaction.Where(x => x.LoanOrderId == request.LoanOrderId).Select(x => x.Transaction).Sum(x => x.CounterAmount);

            if ((TotalPaid + 0.001) >= Total)
            {
                loanOrder.LoanOrderState = LoanOrderState.Finished;
                _context.LoanOrder.Update(loanOrder);
                _context.SaveChanges();
            }

            return _mapper.Map<Model.LoanOrderTransaction>(entity);
        }

    }
}
