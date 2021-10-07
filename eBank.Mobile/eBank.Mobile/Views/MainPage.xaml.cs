using eBank.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;

namespace eBank.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.MyBankAccounts, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.MyBankAccounts:
                        MenuPages.Add(id, new NavigationPage(new AccountsPage()));
                        break;
                    case (int)MenuItemType.Loans:
                        MenuPages.Add(id, new NavigationPage(new LoansPage()));
                        break;
                    case (int)MenuItemType.MyLoans:
                        MenuPages.Add(id, new NavigationPage(new LoanOrdersPage()));
                        break;
                    case (int)MenuItemType.Profile:
                        MenuPages.Add(id, new NavigationPage(new ProfilePage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}