using AutoMapper;
using eBank.Model.Requests;
using eBank.WebAPI.Database;
using eBank.WebAPI.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Services
{
    public class LoanOrderService : ILoanOrderService
    {
        private readonly eBankContext _context;
        private readonly IMapper _mapper;
        private readonly ITransactionService _transactionService;
        public LoanOrderService(eBankContext context, IMapper mapper, ITransactionService transactionService)
        {
            _context = context;
            _mapper = mapper;
            _transactionService = transactionService;
        }

        public List<Model.LoanOrder> Get(LoanOrderSearchRequest search)
        {
            var query = _context.LoanOrder.Include(x => x.Loan).Include(x => x.Loan.Lender).Include(x => x.Loan.Lender.Currency).Include(x => x.Loan.Lender.AccountNumber).Include(x => x.Account).Include(x => x.Account.User).Include(x => x.Account.AccountNumber).Include(x => x.Account.AccountType).AsQueryable();

            if (search.UserId.HasValue)
            {
                query = query.Where(x => x.Account.UserId == search.UserId.Value);
            }

            if (search.LoanId.HasValue)
            {
                query = query.Where(x => x.LoanId == search.LoanId);
            }

            if (search.LoanOrderState.HasValue)
            {
                LoanOrderState los = (LoanOrderState)search.LoanOrderState.Value;
                query = query.Where(x => x.LoanOrderState == los);
            }

            if (!string.IsNullOrWhiteSpace(search?.LoanName))
            {
                query = query.Where(x => x.Loan.Name.StartsWith(search.LoanName));
            }

            if (!string.IsNullOrWhiteSpace(search?.JMBG))
            {
                query = query.Where(x => x.Account.User.JMBG.Contains(search.JMBG));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.LoanOrder>>(list);

            /*var list = _context.LoanOrder.Include(x => x.Loan).Include(x=>x.Loan.Lender).Include(x=>x.Loan.Lender.Currency).Include(x => x.Account).Include(x=>x.Account.AccountNumber).Include(x => x.Account.AccountType).Where(x => x.Account.UserId == search.UserId).ToList();

            return _mapper.Map<List<Model.LoanOrder>>(list);*/
        }

        public Model.LoanOrder GetById(int id)
        {
            var entity = _context.LoanOrder.Find(id);

            return _mapper.Map<Model.LoanOrder>(entity);
        }

        public Model.LoanOrder Insert(LoanOrderUpsertRequest request)
        {
            if(request.LoanOrderState!=Model.LoanOrderState.Ordered)
            {
                throw new UserException("Can't create loan order with state other than 'Ordered'");
            }

            var entity = _mapper.Map<Database.LoanOrder>(request);

            _context.LoanOrder.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.LoanOrder>(entity);
        }

        public Model.LoanOrder Update(int id, LoanOrderUpsertRequest request)
        {

            var loanOrder = _context.LoanOrder.Include(x=>x.Account).Include(x => x.Account.AccountNumber).Include(x => x.Loan).Include(x => x.Loan.Lender).Include(x => x.Loan.Lender.AccountNumber).Where(x => x.LoanOrderId == id).SingleOrDefault();
            
            //Used inside if blocks to allow update only from/to certain LoanOrderState switches (to deny state switches like Active to Denied, which isn't logical)
            bool AllowUpdate = false;

            if(loanOrder==null)
            {
                throw new UserException("Loan order not found");
            }

            //If loan order is ordered, and it's switching state from ordered to active, we have to transfer funds from lender's account to client's account 
            if (loanOrder.LoanOrderState==LoanOrderState.Ordered && request.LoanOrderState == Model.LoanOrderState.Active)
            {
                var transactionRequest = new TransactionInsertRequest()
                {
                    Amount = request.Amount,
                    SenderNumber = loanOrder.Loan.Lender.AccountNumber.Number,
                    RecipientNumber = loanOrder.Account.AccountNumber.Number,
                    Date = DateTime.Now,
                    Description = "Loan transfer to client"
                };

                if(_transactionService.Insert(transactionRequest)==null)
                {
                    throw new UserException("Error setting Loan order as active - transaction of funds to client's account failed");
                }

                AllowUpdate = true;

            }
            else if (loanOrder.LoanOrderState==LoanOrderState.Ordered && request.LoanOrderState == Model.LoanOrderState.Denied)
            {
                //Allow switching state from Ordered to Denied (by employee rejecting loan application in desktop app (loan order))
                AllowUpdate = true;
            }
            else if(loanOrder.LoanOrderState == LoanOrderState.Active && request.LoanOrderState == Model.LoanOrderState.Finished)
            {
                //Allow switching state from Active to Finished (by Client paying back total sum using mobile app)
                AllowUpdate = true;
            }

            if(AllowUpdate)
            {
                var entity = _context.LoanOrder.Find(id);
                _context.LoanOrder.Attach(entity);
                _context.LoanOrder.Update(entity);
                _mapper.Map(request, entity);
                _context.SaveChanges();

                return _mapper.Map<Model.LoanOrder>(entity);
            }
            else
            {
                throw new UserException("Specified Loan order state switching isn't allowed");
            }
            
        }
    }
}
