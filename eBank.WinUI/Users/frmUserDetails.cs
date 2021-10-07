using eBank.Model;
using eBank.Model.Requests;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eBank.WinUI.Properties;
using System.Text.RegularExpressions;
using System.IO;
using eBank.WinUI.Helpers;

namespace eBank.WinUI.Users
{
    public partial class frmUserDetails : Form
    {

        APIService _service = new APIService("User");
        APIService _roleService = new APIService("Role");
        APIService _cityService = new APIService("City");
        List<Role> _roles = new List<Role>();
        Random rand = new Random();

        private int? _id = null;
        private byte[] UserPicture = null;

        private bool CheckboxlistLoaded = false;

        public frmUserDetails(int? id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {

                var roleList = new List<int>();
                foreach (var x in clbRole.CheckedItems)
                {
                    roleList.Add(_roles.Where(y => y.Name == x.ToString()).Select(y=>y.RoleId).First());
                }


                var request = new UserUpsertRequest
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    JMBG = txtJMBG.Text,
                    DateOfBirth = dtpDateOfBirth.Value,
                    CityId = (int)cbCity.SelectedValue,
                    Address = txtAddress.Text,
                    Gender = (Gender)((rbMale.Checked)? 0 : 1),
                    Email = txtEmail.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Roles = roleList,
                    Image = UserPicture
                };

                Model.User entity = null;
                if (!_id.HasValue)
                {
                    entity = await _service.Insert<Model.User>(request);
                }
                else
                {
                    entity = await _service.Update<Model.User>(_id.Value, request);
                }

                if (entity != null)
                {
                    MessageBox.Show("Success!");
                }

            }
        }

        private void txtJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Checking if entered value is digit or control
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private async void frmUserDetails_Load(object sender, EventArgs e)
        {

            var cities = await _cityService.Get<List<Model.City>>(null);

            cbCity.DataSource = cities;
            cbCity.DisplayMember = "Name";
            cbCity.ValueMember = "CityId";

            _roles = await _roleService.Get<List<Model.Role>>(null);

            clbRole.CheckOnClick = true;
            clbRole.Items.AddRange(_roles.Select(x=> x.Name).ToArray());

            if (_id.HasValue)
            {
                var entity = await _service.GetById<Model.User>(_id);
                
                txtFirstName.Text = entity.FirstName;
                txtLastName.Text = entity.LastName;
                txtJMBG.Text = entity.JMBG;
                dtpDateOfBirth.Value = entity.DateOfBirth;
                cbCity.SelectedValue = entity.CityId; 
                txtAddress.Text = entity.Address;
                txtEmail.Text = entity.Email;
                txtUsername.Text = entity.Username;
                if((int)entity.Gender == 0) { rbMale.Checked = true; } else { rbFemale.Checked = true; }
                
                //pictureBox.Image = Image.FromStream(UserPicture.ToStream());

                if (entity.Image.Length != 0)
                {
                    UserPicture = entity.Image;
                    pictureBox.Image = ImageHelper.ByteArrayToSystemDrawing(UserPicture);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                foreach (var x in entity.UserRoles)
                {
                    for (var n = 0; n < _roles.Count(); n++)
                    {
                        if (x.Role.Name==clbRole.Items[n].ToString()) { clbRole.SetItemChecked(n, true); }
                    }
                }

                CheckboxlistLoaded = true;

            }
            else
            {
                SuggestUsername(10);
                SuggestPassword(10);
            }

        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                errorProviderUserDetails.SetError(txtFirstName, Resources.Validation_RequiredField);
            }
            else
            {
                errorProviderUserDetails.SetError(txtFirstName, null);
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                errorProviderUserDetails.SetError(txtLastName, Resources.Validation_RequiredField);
            }
            else
            {
                errorProviderUserDetails.SetError(txtLastName, null);
            }
        }

        private void txtJMBG_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJMBG.Text))
            {
                e.Cancel = true;
                errorProviderUserDetails.SetError(txtJMBG, Resources.Validation_RequiredField);
            }
            else if(!Regex.Match(txtJMBG.Text, @"^[0-9]{13}$").Success)
            {
                e.Cancel = true;
                errorProviderUserDetails.SetError(txtJMBG, "Must contain 13 numbers only");
            }
            else
            {
                errorProviderUserDetails.SetError(txtJMBG, null);
            }
        }

        private void cbCity_Validating(object sender, CancelEventArgs e)
        {
            if (cbCity.SelectedItem==null) {
                e.Cancel = true;
                errorProviderUserDetails.SetError(cbCity, Resources.Validation_RequiredField);
            }
            else
            {
                errorProviderUserDetails.SetError(cbCity, null);
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                e.Cancel = true;
                errorProviderUserDetails.SetError(txtAddress, Resources.Validation_RequiredField);
            }
            else
            {
                errorProviderUserDetails.SetError(txtAddress, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                errorProviderUserDetails.SetError(txtEmail, Resources.Validation_RequiredField);
            }
            else
            {
                errorProviderUserDetails.SetError(txtEmail, null);
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                e.Cancel = true;
                errorProviderUserDetails.SetError(txtUsername, Resources.Validation_RequiredField);
            }
            else
            {
                errorProviderUserDetails.SetError(txtUsername, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!_id.HasValue)
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    e.Cancel = true;
                    errorProviderUserDetails.SetError(txtPassword, Resources.Validation_RequiredField);
                }
                else
                {
                    errorProviderUserDetails.SetError(txtPassword, null);
                }
            }
        }

        private void clbRoles_Validating(object sender, CancelEventArgs e)
        {

            if (clbRole.CheckedItems.Count < 1)
            {
                e.Cancel = true;
                errorProviderUserDetails.SetError(clbRole, "Must check at least one");
            }
            else
            {
                errorProviderUserDetails.SetError(clbRole, null);
            }
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                UserPicture = file;
                txtPictureInput.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBox.Image = image;
            }

        }

        private void clbRole_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(!APIService.IsAdmin && CheckboxlistLoaded)
            {
                //if (e.CurrentValue == CheckState.Checked) e.NewValue = CheckState.Checked;

                var items = clbRole.Items;
                int adminIndex = 0;
                int employeeIndex = 0;

                for(int i = 0; i < items.Count; i++)
                {
                    if(items[i].ToString()=="Administrator")
                    {
                        adminIndex = i;
                    }
                    else if (items[i].ToString() == "Employee")
                    {
                        employeeIndex = i;
                    }
                }

                if(e.Index == adminIndex || e.Index == employeeIndex)
                {
                    MessageBox.Show("Only administrator can set or change this role!");
                    e.NewValue = e.CurrentValue;
                }

            }

        }

        private void btnSuggest_Click(object sender, EventArgs e)
        {
            //We recommend password to user here
            SuggestPassword(10);
        }

        private void btnSuggestUsername_Click(object sender, EventArgs e)
        {
            //We recommend username to user here
            SuggestUsername(10);
        }

        private void SuggestPassword(int length)
        {
            txtPassword.Text = GenerateRandomString(length);
        }

        private void SuggestUsername(int length)
        {
            txtUsername.Text = GenerateRandomString(length);
        }

        private string GenerateRandomString(int length)
        {
            string pool = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            string output = "";

            for (int i = 0; i < length; i++)
            {

                output += pool[rand.Next(0, 61)];

            }

            return output;
        }

    }
}
