﻿using eBank.Mobile.Views;
using eBank.Model;
using eBank.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBank.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("User");
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; set; }

        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            try
            {
                await _service.Get<dynamic>(null);
                var usr = new UserSearchRequest { Username = APIService.Username };
                APIService.User = new List<User>(await _service.Get<List<User>>(usr)).First();

                Application.Current.MainPage = new MainPage();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
