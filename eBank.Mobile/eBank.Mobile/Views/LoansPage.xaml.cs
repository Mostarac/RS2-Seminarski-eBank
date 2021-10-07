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
    public partial class LoansPage : ContentPage
    {
        private LoansViewModel model = null;
        public LoansPage()
        {
            InitializeComponent();
            BindingContext = model = new LoansViewModel() { Navigation = Navigation };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        /*private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var item = e.SelectedItem as Account;

            //await Navigation.PushAsync(new ProizvodDetailPage(item));
        }*/
    }
}