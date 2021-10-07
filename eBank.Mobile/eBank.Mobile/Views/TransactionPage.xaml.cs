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
    public partial class TransactionPage : ContentPage
    {
        public TransactionPage(Account account)
        {
            InitializeComponent();
            this.BindingContext = new TransactionViewModel() { Navigation = Navigation, Account = account };
        }
    }
}