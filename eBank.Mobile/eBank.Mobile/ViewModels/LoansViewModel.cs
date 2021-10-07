using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using eBank.Mobile.Views;
using eBank.Model;
using eBank.Model.Requests;
using Xamarin.Forms;

namespace eBank.Mobile.ViewModels
{
    public class LoansViewModel : BaseViewModel
    {
        private readonly APIService _loanService = new APIService("Loan");
        public INavigation Navigation { get; set; }

        public LoansViewModel()
        {
            InitCommand = new Command(async () => await Init());
            NewLoanOrderCommand = new Command(async (lnp) => await NewLoanOrder(lnp));
        }
        public ObservableCollection<Loan> LoanList { get; set; } = new ObservableCollection<Loan>();

        public ICommand InitCommand { get; set; }
        public ICommand NewLoanOrderCommand { get; set; }

        public async Task Init()
        {

            LoanSearchRequest search = new LoanSearchRequest() { Name = ""};

            var list = await _loanService.Get<IEnumerable<Loan>>(search);

            LoanList.Clear();

            foreach (var loan in list)
            {
                LoanList.Add(loan);
            }
        }

        public async Task NewLoanOrder(object lnp)
        {
            Loan loan = (Loan)lnp;
            await Navigation.PushAsync(new NewLoanOrderPage(loan));
        }
    }
}
