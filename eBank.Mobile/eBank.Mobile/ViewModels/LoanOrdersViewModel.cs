using eBank.Mobile.Views;
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
    public class LoanOrdersViewModel : BaseViewModel, INotifyPropertyChanged
    {

        private readonly APIService _loanOrderService = new APIService("LoanOrder");

        public INavigation Navigation { get; set; }
        public LoanOrdersViewModel()
        {
            InitCommand = new Command(async () => await Init());
            ButtonActionCommand = new Command(async (order) => await ButtonAction(order));
        }
        public ObservableCollection<LoanOrderCustom> LoanOrderCustomList { get; set; } = new ObservableCollection<LoanOrderCustom>();

        public ICommand InitCommand { get; set; }
        public ICommand ButtonActionCommand { get; set; }

        public async Task ButtonAction(object order)
        {

            LoanOrderCustom loc = (LoanOrderCustom)order;

            //await Application.Current.MainPage.DisplayAlert("Success", "Is working, loan amount: " + loc.LoanOrder.Amount.ToString(), "OK");

            if (loc.LoanOrderState == LoanOrderState.Active.ToString())
            {
                //call LoanPaymentsPage and set LoanOrder parameter there :)
                await Navigation.PushAsync(new LoanOrderDetailPage(loc.LoanOrder));

            }
            else if(loc.LoanOrderState == LoanOrderState.Finished.ToString())
            {
                await Navigation.PushAsync(new LoanOrderDetailPage(loc.LoanOrder));
            }
            else if (loc.LoanOrderState == LoanOrderState.Denied.ToString())
            {
                await Navigation.PushAsync(new NewLoanOrderPage(loc.LoanOrder.Loan));
            }
            else if (loc.LoanOrderState == LoanOrderState.Ordered.ToString())
            {
                
            }
        }

        public async Task Init()
        {

            LoanOrderSearchRequest search = new LoanOrderSearchRequest() { UserId = APIService.User.UserId };

            var list = await _loanOrderService.Get<IEnumerable<LoanOrder>>(search);

            LoanOrderCustomList.Clear();

            foreach (var x in list)
            {
                double A; //monthly payment rate amount
                double P = x.Amount; //loan amount
                int N = x.Months; //number of months
                double r = x.Loan.EIR / 100 / 12; //total effective rate amount per period (month)

                A = P * (r * Math.Pow(1 + r, N)) / (Math.Pow(1 + r, N) - 1);

                double TotalDouble = A * N;
                string Total = Math.Round(TotalDouble, 2).ToString() + " " + x.Loan.Lender.Currency.CurrencyId;
                string TotalInterest = Math.Round((TotalDouble - P), 2).ToString() + " " + x.Loan.Lender.Currency.CurrencyId;
                string MonthlyRate = Math.Round(A, 2).ToString() + " " + x.Loan.Lender.Currency.CurrencyId;

                LoanOrderCustomList.Add(new LoanOrderCustom
                {
                    LoanOrder = x,
                    LoanName = x.Loan.Name,
                    InterestRate = "Interest rate: " + x.Loan.EIR.ToString() + "%",
                    TargetAccount = ((x.LoanOrderState == LoanOrderState.Active) ? "Deposited on: " : ((x.LoanOrderState == LoanOrderState.Ordered) ? "Will be deposited on: " : (x.LoanOrderState == LoanOrderState.Denied) ? "Not deposited on: " : "Deposited on: ")) + x.Account.AccountType.Name + " " + x.Account.AccountNumber.Number,
                    Amount = "Loan amount: " + x.Amount.ToString() + " " + x.Loan.Lender.CurrencyId,
                    TotalInterest = "Interest amount: " + TotalInterest,
                    Months = "Payments: " + x.Months.ToString(),
                    MonthlyRate = "Monthly: " + MonthlyRate,
                    LoanOrderState = x.LoanOrderState.ToString(),
                    CreationDate = "Ordering date: " + x.CreationDate.ToString("dd/MM/yyyy"),
                    Comment = (x.LoanOrderState == LoanOrderState.Denied)? "Bank's comment: " + x.Comment : "",
                    ButtonText = (x.LoanOrderState==LoanOrderState.Active)? "Manage payments" : ((x.LoanOrderState==LoanOrderState.Ordered)? "Cancel order" : (x.LoanOrderState == LoanOrderState.Denied) ? "New order" : "View history"),
                    ButtonVisible = !(x.LoanOrderState == LoanOrderState.Ordered)

                });
            }
        }

        public class LoanOrderCustom
        {
            public LoanOrder LoanOrder { get; set; }
            public string LoanName { get; set; }
            public string InterestRate { get; set; }
            public string TargetAccount { get; set; }
            public string Amount { get; set; }
            public string TotalInterest { get; set; }
            public string Months { get; set; }
            public string MonthlyRate { get; set; }
            public string LoanOrderState { get; set; }
            public string CreationDate { get; set; }
            public string Comment { get; set; }
            public string ButtonText { get; set; }

            public bool ButtonVisible { get; set; }

        }
    }
}