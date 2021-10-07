using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using eBank.Mobile.Views;
using eBank.Model;
using eBank.Model.Requests;
using Xamarin.Forms;

namespace eBank.Mobile.ViewModels
{
    public class AccountsViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private readonly APIService _accountService = new APIService("Account");
        public INavigation Navigation { get; set; }
        public AccountsViewModel()
        {
            InitCommand = new Command(async () => await Init());
            TransactionHistoryCommand = new Command(async (acc) => await TransactionHistory(acc));
            NewTransactionCommand = new Command(async (acc) => await NewTransaction(acc));
        }
        public ObservableCollection<Account> AccountList { get; set; } = new ObservableCollection<Account>();

        public ICommand InitCommand { get; set; }
        public ICommand TransactionHistoryCommand { get; set; }
        public ICommand NewTransactionCommand { get; set; }

        public async Task Init()
        {

            AccountSearchRequest search = new AccountSearchRequest() { UserId = APIService.User.UserId };

            var list = await _accountService.Get<IEnumerable<Account>>(search);

            AccountList.Clear();

            foreach(var acc in list)
            {
                AccountList.Add(acc);
            }
        }
        
        public async Task TransactionHistory(object acc)
        {
            Account account = (Account)acc;

            await Navigation.PushAsync(new TransactionHistoryPage(account));
        }
        public async Task NewTransaction(object acc)
        {
            Account account = (Account)acc;
            await Navigation.PushAsync(new TransactionPage(account));
        }
    }
}
