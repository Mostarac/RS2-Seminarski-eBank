using eBank.Model;
using eBank.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBank.Mobile.ViewModels
{
    public class TransactionViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private readonly APIService _transactionService = new APIService("Transaction");
        public INavigation Navigation { get; set; }

        public TransactionViewModel()
        {
            TransactCommand = new Command(async () => await Transact());
        }

        string _recipientNumber = string.Empty;
        public string RecipientNumber
        {
            get { return _recipientNumber; }
            set { SetProperty(ref _recipientNumber, value); }
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

        string _description;
        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        public Account Account { get; set; }

        public ICommand TransactCommand { get; set; }

        async Task Transact()
        {
            if(string.IsNullOrEmpty(RecipientNumber) || !Regex.Match(RecipientNumber, @"^[0-9]{16}$").Success)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Recipient account number must be 16 digits long", "OK");
                return;
            }
            else if(!Regex.Match(_amount, @"^[0-9]{0,10}\.?[0-9]{1,10}$").Success)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Amount must be numeric with dot (.) as separator", "OK");
                return;
            }
            else if(!double.TryParse(_amount, System.Globalization.NumberStyles.AllowDecimalPoint, CultureInfo.CreateSpecificCulture("en-US"), out _amountDouble))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Error parsing the amount", "OK");
                return;
            }
            else if (_amountDouble <= 0)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Amount must be greater than 0", "OK");
                return;
            }
            else if(_amountDouble > (Account.Balance + Account.Limit))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Balance is too low to make specified transaction", "OK");
                return;
            }
            else
            {
                TransactionInsertRequest transaction = new TransactionInsertRequest()
                {
                    Amount = _amountDouble,
                    RecipientNumber = _recipientNumber,
                    SenderNumber = Account.AccountNumber.Number,
                    Date = DateTime.Now,
                    Description = _description
                };

                try
                {
                    await _transactionService.Insert<Transaction>(transaction);
                }
                catch
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Error making a transaction, try again later", "OK");
                }

                await Application.Current.MainPage.DisplayAlert("Success", "Transaction successful, " + _amountDouble.ToString() + " " + Account.Currency.CurrencyId + " sent to " + RecipientNumber, "OK");
                await Navigation.PopAsync();

            }
        }
    }
}
