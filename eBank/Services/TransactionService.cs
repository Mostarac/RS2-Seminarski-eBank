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
    public class TransactionService : ITransactionService
    {
        private readonly eBankContext _context;
        private readonly IMapper _mapper;
        public TransactionService(eBankContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Transaction> Get(TransactionSearchRequest search)
        {
            List<Transaction> list = new List<Transaction>();

            if (search.AccountId.HasValue)
            {
                list = _context.Transaction.Include(x => x.Recipient).Include(x => x.Recipient.Account).Include(x => x.Recipient.Account.Currency).Include(x => x.Sender).Include(x => x.Sender.Account).Include(x => x.Sender.Account.Currency).Where(x => x.SenderId == search.AccountId || x.RecipientId == search.AccountId).ToList();
            }

            if (search.LoanOrderId.HasValue)
            {
                list = _context.LoanOrderTransaction.Include(x=>x.Transaction).Include(x => x.Transaction.Recipient).Include(x => x.Transaction.Recipient.Account).Include(x => x.Transaction.Recipient.Account.Currency).Include(x => x.Transaction.Sender).Include(x => x.Transaction.Sender.Account).Include(x => x.Transaction.Sender.Account.Currency).Where(x => x.LoanOrderId == search.LoanOrderId).Select(x => x.Transaction).ToList();
            }

            return _mapper.Map<List<Model.Transaction>>(list);
        }

        public Model.Transaction Insert(TransactionInsertRequest request)
        {
            //Throw exception if both Amount and CounterAmount are specified, or if none are specified (only 1 must be entered)
            if ((request.CounterAmount.HasValue && request.Amount.HasValue) || (!request.CounterAmount.HasValue && !request.Amount.HasValue))
            {
                throw new UserException("Invalid transaction, must specify only Amount or CounterAmount, can't have both specified!");
            }

            //Stop transaction if requested amount or counteramount is 0 or less
            if (request.CounterAmount.HasValue)
            {
                if(request.CounterAmount.Value <=0)
                {
                    throw new UserException("Counteramount must be greater than 0!");
                }
            }
            else if (request.Amount.HasValue)
            {
                if (request.Amount.Value <= 0)
                {
                    throw new UserException("Amount must be greater than 0!");
                }
            }

            //Check if sender account number has it's Account owned by client from our bank's database
            var Sender = _context.Account.Include(x => x.AccountNumber).Where(x => x.AccountNumber.Number == request.SenderNumber).SingleOrDefault();
            AccountNumber SenderNumber = null;

            //Check if recipient account exists in database
            var Recipient = _context.Account.Include(x => x.AccountNumber).Where(x => x.AccountNumber.Number == request.RecipientNumber).SingleOrDefault();
            AccountNumber RecipientNumber = null;

            CurrencyPair pair = null;

            //We perform currency conversion if we have recipient in our database and if we have sender in our database, otherwise we assume transaction is from external account and in Recipient's currency
            if (Sender != null && Recipient != null)
            {
                if (Recipient.CurrencyId != Sender.CurrencyId)
                {
                    //Get CurrencyPair class which holds currencies and countervalue ratio for currency conversion, those values are taken and increase/deduction is performed based on ratio, Example 1 EUR - 1.95 BAM, Ratio is 1.95
                    pair = _context.CurrencyPair.Where(x => (x.FirstId == Sender.CurrencyId || x.SecondId == Sender.CurrencyId) && (x.FirstId == Recipient.CurrencyId || x.SecondId == Recipient.CurrencyId)).SingleOrDefault();

                    if (pair == null)
                    {
                        throw new UserException("Sender and recipient's currency pair not found, can't make a transaction!");
                    }

                    //If request currency code (sender's currency) is 1st of pair, then multiply amount with ratio, if not, divide it to get CounterValue
                    if (Sender.CurrencyId == pair.FirstId)
                    {
                        if (request.CounterAmount.HasValue)
                        {
                            request.Amount = request.CounterAmount / pair.RatioFirstSecond;
                        }
                        else if(request.Amount.HasValue)
                        {
                            request.CounterAmount = request.Amount.Value * pair.RatioFirstSecond;
                        }
                        
                    }
                    else
                    {

                        if (request.CounterAmount.HasValue)
                        {
                            request.Amount = request.CounterAmount * pair.RatioFirstSecond;
                        }
                        else if (request.Amount.HasValue)
                        {
                            request.CounterAmount = request.Amount.Value / pair.RatioFirstSecond;
                        }
                        
                    }
                }
                else
                {
                    //If both are clients of bank, and have same currency, we set amount and counteramount as the same value
                    if (request.Amount.HasValue)
                    {
                        request.CounterAmount = request.Amount;
                    }
                    else if (request.CounterAmount.HasValue)
                    {
                        request.Amount = request.CounterAmount;
                    }
                }
            }
            else
            {
                //If sender or recipient, or both, aren't clients of bank, we set amount and counteramount as the same value
                if(request.Amount.HasValue)
                {
                    request.CounterAmount = request.Amount;
                } 
                else if(request.CounterAmount.HasValue)
                {
                    request.Amount = request.CounterAmount;
                }

            }

            if (Sender == null)
            {
                //If it isn't in our database,
                //Check if sender number starts with "155", meaning it's internal client bank's account number, but it wasnt found among internal clients so we throw exception
                if (request.SenderNumber.StartsWith("155"))
                {
                    throw new UserException("Internal sender account with specified number not found!");
                }

                //Internal account with number isn't found, lets check if external account number exists with that number
                SenderNumber = _context.AccountNumber.Where(x => x.Number == request.SenderNumber).SingleOrDefault();
                if (SenderNumber == null)
                {
                    //If it doesn't, we add it
                    SenderNumber = new AccountNumber { Number = request.SenderNumber };
                    _context.AccountNumber.Add(SenderNumber);
                    _context.SaveChanges();
                }

            }
            else
            {
                //If sender is internal client's account

                SenderNumber = Sender.AccountNumber;

                //Check if sender has enough on balance to transact
                if ((Sender.Balance - request.Amount.Value) < -(Sender.Limit))
                {
                    //If not
                    throw new UserException("Not enough funds on sender account");
                }

                //Deduct amount from sender's balance and update Sender account record in database
                Sender.Balance -= request.Amount.Value;
                _context.Account.Update(Sender);
                _context.SaveChanges();
            }

            if (Recipient == null)
            {

                //If internal client bank account isn't found (is null), but number in request starts with "155", meaning it's internal client bank's account number, we have to throw exception
                if (request.RecipientNumber.StartsWith("155"))
                {
                    throw new UserException("Internal recipient account with specified number not found!");
                }

                //Internal account with number isn't found, lets check if external account number exists in database with that number
                RecipientNumber = _context.AccountNumber.Where(x => x.Number == request.RecipientNumber).SingleOrDefault();
                if (RecipientNumber == null)
                {
                    //If external account number doesn't exist in our database, we add it
                    RecipientNumber = new AccountNumber { Number = request.RecipientNumber };
                    _context.AccountNumber.Add(RecipientNumber);
                    _context.SaveChanges();
                }
                
            }
            else
            {
                RecipientNumber = Recipient.AccountNumber;

                //Recipient's balance is finally increased by countervalue and Recipient account record updated in database
                Recipient.Balance += request.CounterAmount.Value;
                _context.Account.Update(Recipient);
                _context.SaveChanges();

            }

            //Create new transaction entity to be added to database
            Database.Transaction entity = new Database.Transaction
            {
                RecipientId = RecipientNumber.AccountNumberId,
                SenderId = SenderNumber.AccountNumberId,
                Amount = request.Amount.Value,
                CounterAmount = request.CounterAmount.Value,
                Date = request.Date,
                Description = request.Description
            };

            _context.Transaction.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Transaction>(entity);
        }
    }
}
