using eBank.Mobile.ViewModels;
using eBank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eBank.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountsPage : ContentPage
    {
        private AccountsViewModel model = null;
        public AccountsPage()
        {
            InitializeComponent();
            BindingContext = model = new AccountsViewModel() { Navigation = Navigation };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        /*private async void BtnHistory_Clicked(object sender, EventArgs e)
        {
            int accId = (int)((Button)sender).CommandParameter;

            await Application.Current.MainPage.DisplayAlert("Error", accId.ToString(), "OK");

            await Navigation.PushAsync(new LoansPage());
        }
        private async void BtnNewTransaction_Clicked(object sender, EventArgs e)
        {
            int accId = (int)((Button)sender).CommandParameter;

            await Application.Current.MainPage.DisplayAlert("Error", accId.ToString(), "OK");

            await Navigation.PushAsync(new LoansPage());
        }*/

        /*private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var item = e.SelectedItem as Account;

            SelectedAcc = e.SelectedItem as Account;

            //await Navigation.PushAsync(new ProizvodDetailPage(item));
        }*/
    }
}