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

    public class TransactionHistoryViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private readonly APIService _transactionService = new APIService("Transaction");
        public INavigation Navigation { get; set; }
        public Account Account { get; set; }

        public TransactionHistoryViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<TransactionCustom> TransactionCustomList { get; set; } = new ObservableCollection<TransactionCustom>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {

            TransactionSearchRequest search = new TransactionSearchRequest() { AccountId = Account.AccountId };

            var list = await _transactionService.Get<IEnumerable<Transaction>>(search);

            TransactionCustomList.Clear();

            foreach (var t in list)
            {

                var Outgoing = Account.AccountId == t.SenderId;

                TransactionCustomList.Add(new TransactionCustom
                {
                    TransactionId = t.TransactionId,
                    Type = (Outgoing) ? "Outgoing" : "Incoming",
                    Amount = (Outgoing) ? "-" + Math.Round(t.Amount, 2).ToString() + " " + Account.Currency.Symbol : "+" + Math.Round(t.CounterAmount, 2).ToString() + " " + Account.Currency.Symbol + " (" + Math.Round(t.Amount, 2).ToString() + t.Sender.Account.Currency.Symbol + ")",
                    Participant = (Outgoing) ? "To " + t.Recipient.Number.ToString() : "From " + t.Sender.Number.ToString(),
                    Date = t.Date.ToString("dd.MM.yyyy"),
                    Description = "Description: " + t.Description

                });
            }
        }

        public class TransactionCustom {

            public int TransactionId { get; set; }
            public string Type { get; set; }
            public string Amount { get; set; }
            public string Participant { get; set; }
            public string Date { get; set; }
            public string Description { get; set; }

        };


    }
}
