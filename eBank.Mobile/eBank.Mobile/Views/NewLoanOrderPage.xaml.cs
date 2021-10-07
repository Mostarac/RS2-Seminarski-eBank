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
    public partial class NewLoanOrderPage : ContentPage
    {
        private NewLoanOrderViewModel model = null;
        public NewLoanOrderPage(Loan loan)
        {
            InitializeComponent();
            this.BindingContext = model = new NewLoanOrderViewModel() { Navigation = Navigation, Loan = loan };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

    }
}