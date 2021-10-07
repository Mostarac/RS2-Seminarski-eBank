using eBank.Mobile.ViewModels;
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
    public partial class LoanOrdersPage : ContentPage
    {
        private LoanOrdersViewModel model = null;
        public LoanOrdersPage()
        {
            InitializeComponent();
            BindingContext = model = new LoanOrdersViewModel() { Navigation = Navigation };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

    }
}