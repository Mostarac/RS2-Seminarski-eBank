using eBank.Model;
using eBank.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBank.Mobile.ViewModels
{
    public class NewLoanOrderViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private readonly APIService _loanOrderService = new APIService("LoanOrder");
        private readonly APIService _accountService = new APIService("Account");
        public INavigation Navigation { get; set; }

        public NewLoanOrderViewModel()
        {
            InitCommand = new Command(async () => await Init());
            OrderLoanCommand = new Command(async () => await OrderLoan());
            RecommendPeriodCommand = new Command(async () => await RecommendPaymentPeriod());
            CalculateTotalsCommand = new Command(async () => await CalculateRateAndTotals());
        }

        public ObservableCollection<Account> AccountList { get; set; } = new ObservableCollection<Account>();
        Account _selectedAccount = null;

        public Account SelectedAccount
        {
            get { return _selectedAccount; }
            set { SetProperty(ref _selectedAccount, value); }
        }

        string _months;
        public string Months
        {
            get { return _months; }
            set { SetProperty(ref _months, value); }
        }

        int _monthsInt;
        public int MonthsInt
        {
            get { return _monthsInt; }
            set { SetProperty(ref _monthsInt, value); }
        }

        string _amount;
        public string Amount
        {
            get { return _amount; }
            set { SetProperty(ref _amount, value); }
        }

        double _amountDouble;
        public double AmountDouble
        {
            get { return _amountDouble; }
            set { SetProperty(ref _amountDouble, value); }
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

        public Loan Loan { get; set; }

        public ICommand OrderLoanCommand { get; set; }
        public ICommand InitCommand { get; set; }
        public ICommand RecommendPeriodCommand { get; set; }
        public ICommand CalculateTotalsCommand { get; set; }

        public async Task Init()
        {
            AccountSearchRequest search = new AccountSearchRequest() { UserId = APIService.User.UserId };

            var list = await _accountService.Get<IEnumerable<Account>>(search);

            AccountList.Clear();

            foreach (var acc in list)
            {
                AccountList.Add(acc);
            }
        }

        async Task OrderLoan()
        {

            double amount;
            int months;
            
            if (!double.TryParse(Amount, out amount) )
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Invalid loan amount entered", "OK");
                return;
            };

            if (!int.TryParse(Months, out months)) 
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Invalid number of months entered", "OK");
                return;
            };

            if (amount <= 0 || amount > Loan.Limit)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Loan amount must be greater than 0 and less than loan limit ", "OK");
                return;
            }

            if (months < Loan.MinPayments || months > Loan.MaxPayments)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Invalid payment period", "OK");
                return;
            }

            if (SelectedAccount==null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must select an account to deposit funds on", "OK");
                return;
            }


            LoanOrderUpsertRequest loanOrder = new LoanOrderUpsertRequest
            {
                LoanId = Loan.LoanId,
                AccountId = SelectedAccount.AccountId,
                Amount = amount,
                Months = months,
                LoanOrderState = LoanOrderState.Ordered,
                CreationDate = DateTime.Now
            };

            if(await _loanOrderService.Insert<LoanOrder>(loanOrder)==null)
            {
                return;
            }

            await Application.Current.MainPage.DisplayAlert("Success", "Loan succesfully ordered!", "OK");
            await Navigation.PopAsync();

        }
        async Task RecommendPaymentPeriod()
        {

        }

        async Task CalculateRateAndTotals()
        {

            try
            {
                double A; //monthly payment rate amount
                double P = double.Parse(Amount); //loan amount
                int N = int.Parse(Months); //number of months
                double r = Loan.EIR / 100 / 12; //total effective rate amount per period (month)

                A = P * (r * Math.Pow(1 + r, N)) / (Math.Pow(1 + r, N) - 1);

                double TotalDouble = A * N;
                Total = Math.Round(TotalDouble, 2).ToString() + " " + Loan.Lender.Currency.CurrencyId;
                TotalInterest = Math.Round((TotalDouble - P), 2).ToString() + " " + Loan.Lender.Currency.CurrencyId;
                MonthlyRate = Math.Round(A, 2).ToString() + " " + Loan.Lender.Currency.CurrencyId;
            }
            catch
            {
                Application.Current.MainPage.DisplayAlert("Error", "Error calculating totals and monthly payment rate", "OK");
            }

        }
    }
}

