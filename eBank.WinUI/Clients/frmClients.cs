using eBank.Model.Requests;
using eBank.WinUI.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace eBank.WinUI.Clients
{
    public partial class frmClients : Form
    {
        APIService _userService = new APIService("User");
        List<Model.User> _clients = new List<Model.User>(); 
        public frmClients()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {

            var search = new UserSearchRequest() { IsUlogeLoadingEnabled = true, ClientsOnly = true };
            var text = txtSearchClient.Text;

            if (Regex.Match(txtSearchClient.Text, @"^[0-9]{1,13}$").Success)
            {
                search.JMBG = text;
            }
            else
            {
                search.Name = text;
            }

            /*var search = new UserSearchRequest()
            {
                Name = txtSearchClient.Text,
                IsUlogeLoadingEnabled = true,

            };*/

            var list = await _userService.Get<List<Model.User>>(search);
            dgvClients.AutoGenerateColumns = false;

            dgvClients.DataSource = list;

            _clients = list;

            dgvClients.Refresh();
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Purpose of the following if statement is to check if column header is clicked which also triggers this event and we don't want that
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                frmClientDetails userDetails = new frmClientDetails(_clients[e.RowIndex]);
                userDetails.Show();
            }
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            frmUserDetails userDetails = new frmUserDetails(null);
            userDetails.Show();
        }
    }
}
