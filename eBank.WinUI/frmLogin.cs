using eBank.Model;
using eBank.Model.Requests;
using eBank.WinUI.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eBank.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("User");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            APIService.Username = txtUsername.Text;
            APIService.Password = txtPassword.Text;
            try
            {
                await _service.Get<dynamic>(null);
                // _service.UpdateLoggedUserInfo();

                var usr = new UserSearchRequest { Username = APIService.Username };
                APIService.User = new List<User>(await _service.Get<List<User>>(usr)).First();

                var userRoles = APIService.User.UserRoles.Select(x => x.Role).ToList();
                foreach (var x in userRoles)
                {
                    if (x.Name == "Administrator")
                    {
                        APIService.IsAdmin = true;
                    }

                    if (x.Name == "Employee")
                    {
                        APIService.IsEmployee = true;
                    }
                }

                if (APIService.IsAdmin || APIService.IsEmployee)
                {
                    this.Hide();
                    frmIndex frm = new frmIndex();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("To access desktop module you need Administrator/Employee role.", "Authorization error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show("Login error");
                MessageBox.Show(ex.Message, "Authentication error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
