using eBank.Model;
using eBank.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBank.Mobile.ViewModels
{
    public class LoanOrderDetailViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private readonly APIService _transactionService = new APIService("Transaction");
        private readonly APIService _loanOrderTransactionService = new APIService("LoanOrderTransaction");
        private readonly APIService _accountService = new APIService("Account");

        public INavigation Navigation { get; set; }

        public LoanOrderDetailViewModel()
        {
            InitCommand = new Command(async () => await Init());
            PayCommand = new Command(async (par) => await Pay(par));
            //ViewPaymentsCommand = new Command(async () => await ViewPayments());
        }

        public ObservableCollection<Account> AccountList { get; set; } = new ObservableCollection<Account>();
        public ObservableCollection<Transaction> TransactionList { get; set; } = new ObservableCollection<Transaction>();
        Account _selectedAccount = null;
        public LoanOrder _loanOrder { get; set; }

        public Account SelectedAccount
        {
            get { return _selectedAccount; }
            set { SetProperty(ref _selectedAccount, value); }
        }

        bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set { SetProperty(ref _isActive, value); }
        }

        string _amount;
        public string Amount
        {
            get { return _amount; }
            set { SetProperty(ref _amount, value); }
        }

        string _totalInterest;
        public string TotalInterest
        {
            get { return _totalInterest; }
            set { SetProperty(ref _totalInterest, value); }
        }

        string _total;
        public string Total
        {
            get { return _total; }
            set { SetProperty(ref _total, value); }
        }

        string _monthlyRate;
        public string MonthlyRate
        {
            get { return _monthlyRate; }
            set { SetProperty(ref _monthlyRate, value); }
        }

        double _monthlyRateDouble;
        public double MonthlyRateDouble
        {
            get { return _monthlyRateDouble; }
            set { SetProperty(ref _monthlyRateDouble, value); }
        }

        string _payNext;
        public string PayNext
        {
            get { return _payNext; }
            set { SetProperty(ref _payNext, value); }
        }

        double _payNextDouble;
        public double PayNextDouble
        {
            get { return _payNextDouble; }
            set { SetProperty(ref _payNextDouble, value); }
        }

        string _remaining;
        public string Remaining
        {
            get { return _remaining; }
            set { SetProperty(ref _remaining, value); }
        }

        double _remainingDouble;
        public double RemainingDouble
        {
            get { return _remainingDouble; }
            set { SetProperty(ref _remainingDouble, value); }
        }

        string _nextPaymentDue;
        public string NextPaymentDue
        {
            get { return _nextPaymentDue; }
            set { SetProperty(ref _nextPaymentDue, value); }
        }

        string _warning;
        public string Warning
        {
            get { return _warning; }
            set { SetProperty(ref _warning, value); }
        }

        string _balance;
        public string Balance
        {
            get { return _warning; }
            set { SetProperty(ref _warning, value); }
        }

        string _customPaymentAmount;
        public string CustomPaymentAmount
        {
            get { return _customPaymentAmount; }
            set { SetProperty(ref _customPaymentAmount, value); }
        }

        double _customPaymentAmountDouble;
        public double CustomPaymentAmountDouble
        {
            get { return _customPaymentAmountDouble; }
            set { SetProperty(ref _customPaymentAmountDouble, value); }
        }

        string _loanCurrency;

        public ICommand InitCommand { get; set; }
        public ICommand PayCommand { get; set; }

        //public ICommand ViewPaymentsCommand { get; set; }

        public async Task Init()
        {
            IsActive = _loanOrder.LoanOrderState == LoanOrderState.Active;

            SelectedAccount = null;

            Balance = "";

            _loanCurrency = _loanOrder.Loan.Lender.CurrencyId;

            AccountSearchRequest searchA = new AccountSearchRequest() { UserId = APIService.User.UserId };

            var listA = await _accountService.Get<IEnumerable<Account>>(searchA);

            AccountList.Clear();

            foreach (var acc in listA)
            {
                AccountList.Add(acc);
            }

            TransactionSearchRequest searchT = new TransactionSearchRequest() { LoanOrderId = _loanOrder.LoanOrderId };

            var listT = await _transactionService.Get<IEnumerable<Transaction>>(searchT);

            TransactionList.Clear();

            if (listT != null)
            {
                foreach (var t in listT)
                {
                    TransactionList.Add(t);
                }
            }

            Amount = _loanOrder.Amount.ToString() + " " + _loanCurrency;

            double A; //monthly payment rate amount
            double P = _loanOrder.Amount; //loan amount
            int N = _loanOrder.Months; //number of months
            double r = _loanOrder.Loan.EIR / 100 / 12; //total effective rate amount per period (month)

            A = P * (r * Math.Pow(1 + r, N)) / (Math.Pow(1 + r, N) - 1);

            double TotalDouble = A * N;
            Total = Math.Round(TotalDouble, 2).ToString() + " " + _loanCurrency;
            TotalInterest = Math.Round((TotalDouble - P), 2).ToString() + " " + _loanCurrency;
            MonthlyRateDouble = A;
            MonthlyRate = Math.Round(A, 2).ToString() + " " + _loanCurrency;

            

            //Logic to set value for Remaining amount to be paid off
            //First we get TotalPaid amount
            var TotalPaid = TransactionList.Sum(x => x.CounterAmount);

            //From total amount we substract sum of all Counteramounts in transaction list to get how much has to be paid yet
            RemainingDouble = TotalDouble - TotalPaid;
            Remaining = Math.Round(RemainingDouble, 2).ToString() + " " + _loanCurrency;

            //In case remaining amount to be paid off is smaller than monthly rate, we set PayNext to Remaining amount
            if (RemainingDouble < MonthlyRateDouble)
            {
                PayNextDouble = RemainingDouble;
            }
            else
            {
                PayNextDouble = MonthlyRateDouble;
            }

            PayNext = Math.Round(PayNextDouble, 2).ToString() + " " + _loanCurrency; 

            //Logic to show warning to client in case he/she is late with payments
            //First we calculate how many months have passed from loan order date

            DateTime firstDate = _loanOrder.CreationDate;
            DateTime secondDate = DateTime.Now;

            int m1 = (secondDate.Month - firstDate.Month);//for years
            int m2 = (secondDate.Year - firstDate.Year) * 12; //for months
            int MonthsPassed = m1 + m2;

            if(IsActive==false)
            {
                Warning = "Loan has been fully paid off";
                NextPaymentDue = "";
            }
            else
            {
                //We set NextPaymentDue here
                NextPaymentDue = "Next payment due: " + firstDate.AddMonths(((int)Math.Floor(TotalPaid / MonthlyRateDouble)) + 1).ToString("dd/MM/yyyy");

                //Then we multiply that number of months with monthly payment rate
                var ShouldHavePaid = MonthsPassed * MonthlyRateDouble;

                //Display warning if the paid off amount is less than it should be by that date
                if (TotalPaid < ShouldHavePaid)
                {
                    Warning = "Warning: you are missing payment amount of" + (ShouldHavePaid - TotalPaid).ToString() + " " + _loanCurrency;
                }
                else
                {
                    Warning = "You are on time with your payments";
                    if (TotalPaid > ShouldHavePaid)
                    {
                        Warning += " with " + Math.Round((TotalPaid - ShouldHavePaid), 2).ToString() + " " + _loanCurrency + " paid forward";
                    }
                }
            }

        }

        async Task Pay(object par)
        {

            string parString = (string)par;

            double finalAmount = PayNextDouble;
            string paymentDescription;

            if(parString == "Custom")
            {

                if (!double.TryParse(CustomPaymentAmount, out finalAmount))
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Invalid payment amount entered", "OK");
                    return;
                };

                paymentDescription = "Custom loan payment";

            }
            else
            {
                paymentDescription = "Regular loan payment";
            }

            if (finalAmount <= 0)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Payment amount must be greater than 0", "OK");
                return;
            }

            if (finalAmount < PayNextDouble)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Payment amount must be greater than next payment", "OK");
                return;
            }

            if (finalAmount > RemainingDouble)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Payment amount can't exceed remaining amount of loan", "OK");
                return;
            }

            if (SelectedAccount == null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must select an account to make payment from!", "OK");
                return;
            }

            //Logic for inserting new Transaction and LoanOrderTransaction

            //Instead of making CurrencyPair endpoint, we can just put CounterAmount in TransactionInsertRequest

            //To make next payment rate in Loan's amount, we will have to call currency conversion and convert it into next payment amount

            var transactionRequest = new TransactionInsertRequest
            {
                RecipientNumber = _loanOrder.Loan.Lender.AccountNumber.Number,
                SenderNumber = SelectedAccount.AccountNumber.Number,
                Date = DateTime.Now,
                Description = paymentDescription
            };

            if (_loanOrder.Loan.Lender.CurrencyId == SelectedAccount.CurrencyId)
            {
                transactionRequest.Amount = finalAmount;
            }
            else
            {
                transactionRequest.CounterAmount = finalAmount;
            }

            Transaction transaction = await _transactionService.Insert<Transaction>(transactionRequest);

            if (transaction == null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Error making a payment - can't insert the transaction!", "OK");
                return;
            }

            var loanOrderTransaction = new LoanOrderTransactionUpsertRequest
            {
                LoanOrderId = _loanOrder.LoanOrderId,
                TransactionId = transaction.TransactionId
            };

            await _loanOrderTransactionService.Insert<LoanOrderTransaction>(loanOrderTransaction);


            await Application.Current.MainPage.DisplayAlert("Success", "Payment successfully made!", "OK");

            if((RemainingDouble - finalAmount) <= 0)
            {
                _loanOrder.LoanOrderState = LoanOrderState.Finished;
                await Application.Current.MainPage.DisplayAlert("Success", "You have succesfully paid off your loan!", "OK");
            }

            await Init();
        }

        public async Task ShowBalance()
        {
            if(SelectedAccount!=null)
            {
                Balance = Math.Round(SelectedAccount.Balance, 2).ToString() + " " + SelectedAccount.CurrencyId;
            }
        }

    }
}
