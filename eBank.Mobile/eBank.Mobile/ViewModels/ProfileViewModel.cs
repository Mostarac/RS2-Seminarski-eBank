using eBank.Mobile.Helpers;
using eBank.Model;
using eBank.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBank.Mobile.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        private readonly APIService _userService = new APIService("User");
        private readonly APIService _cityService = new APIService("City");
        public INavigation Navigation { get; set; }

        public ProfileViewModel()
        {
            InitCommand = new Command(async () => await Init());
            UpdateCommand = new Command(async () => await UpdateProfile());
            ChangeImage = new Command(async () => await OnTapped());
        }


        public ObservableCollection<City> CityList { get; set; } = new ObservableCollection<City>();
        City _selectedCity = null;

        public City SelectedCity
        {
            get { return _selectedCity; }
            set { SetProperty(ref _selectedCity, value); }
        }

        string _JMBG;
        public string JMBG
        {
            get { return _JMBG; }
            set { SetProperty(ref _JMBG, value); }
        }

        string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set { SetProperty(ref _fullName, value); }
        }

        string _dateOfBirth;
        public string DateOfBirth
        {
            get { return _dateOfBirth; }
            set { SetProperty(ref _dateOfBirth, value); }
        }

        string _address;
        public string Address
        {
            get { return _address; }
            set { SetProperty(ref _address, value); }
        }

        string _email;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        string _userName;
        public string Username
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value); }
        }

        string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        byte[] _userImage;
        public byte[] UserImage
        {
            get { return _userImage; }
            set { SetProperty(ref _userImage, value); }
        }

        public ICommand UpdateCommand { get; set; }
        public ICommand InitCommand { get; set; }
        public ICommand ChangeImage { get; set; }

        private async Task OnTapped()
        {
            UserImage = await UploadImageHelper.UploadImage(UserImage);
        }

        private async Task UpdateProfile()
        {

            var userRoles = new List<int>();

            foreach(var x in APIService.User.UserRoles)
            {
                userRoles.Add(x.RoleId);
            }

            var request = new UserUpsertRequest
            {
                FirstName = APIService.User.FirstName,
                LastName = APIService.User.LastName,
                JMBG = APIService.User.JMBG,
                DateOfBirth = APIService.User.DateOfBirth,
                CityId = SelectedCity.CityId,
                Address = Address,
                Gender = APIService.User.Gender,
                Email = Email,
                Username = Username,
                Password = Password,
                Roles = userRoles,
                Image = UserImage
            };

            //Password = (Password!=APIService.Password && !string.IsNullOrEmpty(Password)) ? Password : default

            var entity = await _userService.Update<Model.User>(APIService.User.UserId, request);

            if (entity != null)
            {
                APIService.User = entity;
                APIService.Username = entity.Username;
                if(request.Password !=null)
                {
                    APIService.Password = request.Password;
                }
                await Application.Current.MainPage.DisplayAlert("Success", "Profile succesfully updated!", "OK");
                await Navigation.PopAsync();
            }

        }

        public async Task Init()
        {
            var cities = await _cityService.Get<List<Model.City>>(null);

            CityList.Clear();

            foreach (var city in cities)
            {
                CityList.Add(city);
            }

            /*cbCity.DataSource = cities;
            cbCity.DisplayMember = "Name";
            cbCity.ValueMember = "CityId";*/

            APIService.User = await _userService.GetById<Model.User>(APIService.User.UserId); //To get latest data

            UserImage = APIService.User.Image;
            FullName = APIService.User.FirstName + " " + APIService.User.LastName;
            JMBG = APIService.User.JMBG;
            DateOfBirth = APIService.User.DateOfBirth.ToString("dd/MM/yyyy");
            SelectedCity = CityList.SingleOrDefault(x => x.CityId == APIService.User.CityId);
            Address = APIService.User.Address;
            Email = APIService.User.Email;
            Username = APIService.Username;


        /*async Task OrderLoan()
        {

            double amount;
            int months;

            if (!double.TryParse(Amount, out amount))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Invalid loan amount entered", "OK");
                return;
            };

            if (!int.TryParse(Months, out months))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Invalid number of months entered", "OK");
                return;
            };

            if (amount <= 0 || amount > Loan.Limit)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Loan amount must be greater than 0 and less than loan limit ", "OK");
                return;
            }

            if (months < Loan.MinPayments || months > Loan.MaxPayments)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Invalid payment period", "OK");
                return;
            }

            if (SelectedAccount == null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must select an account to deposit funds on", "OK");
                return;
            }


            LoanOrderUpsertRequest loanOrder = new LoanOrderUpsertRequest
            {
                LoanId = Loan.LoanId,
                AccountId = SelectedAccount.AccountId,
                Amount = amount,
                Months = months,
                LoanOrderState = LoanOrderState.Ordered,
                CreationDate = DateTime.Now
            };

            if (await _loanOrderService.Insert<LoanOrder>(loanOrder) == null)
            {
                return;
            }

            await Application.Current.MainPage.DisplayAlert("Success", "Loan succesfully ordered!", "OK");
            await Navigation.PopAsync();
        */
        }
        
    }
}
