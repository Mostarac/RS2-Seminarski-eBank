using System;
using System.Collections.Generic;
using System.Text;

namespace eBank.Mobile.Models
{
    public enum MenuItemType
    {
        MyBankAccounts,
        Loans,
        MyLoans,
        Profile
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
