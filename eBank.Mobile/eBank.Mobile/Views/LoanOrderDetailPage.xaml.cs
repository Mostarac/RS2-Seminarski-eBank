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
    public partial class LoanOrderDetailPage : ContentPage
    {
        private LoanOrderDetailViewModel model = null;
        public LoanOrderDetailPage(LoanOrder loanOrder)
        {
            InitializeComponent();
            this.BindingContext = model = new LoanOrderDetailViewModel() { Navigation = Navigation, _loanOrder = loanOrder };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        protected async void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            await model.ShowBalance();
        }
    }
}