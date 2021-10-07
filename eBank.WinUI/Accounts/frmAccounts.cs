using eBank.Model;
using eBank.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eBank.WinUI.Accounts
{
    public partial class frmAccounts : Form
    {
        APIService _apiAccounts = new APIService("Account");
        private User _client = null;
        List<Model.Account> _accounts = new List<Model.Account>();
        public frmAccounts(User client)
        {
            InitializeComponent();
            _client = client;
        }

        private async void frmAccounts_Load(object sender, EventArgs e)
        {
            var search = new AccountSearchRequest()
            {
                UserId = _client.UserId
            };

            lblClientName.Text += _client.FirstName + " " + _client.LastName;
            lblClientJMBG.Text += _client.JMBG;


            _accounts = await _apiAccounts.Get<List<Model.Account>>(search);

            dgvAccs.AutoGenerateColumns = false;

            dgvAccs.DataSource = _accounts.Select(x=> new { AccountType = x.AccountType.Name, Currency = (x.Currency.Symbol + " " + x.Currency.CurrencyId), Balance = Math.Round(x.Balance, 2)}).ToList();

            dgvAccs.Refresh();
        }

        private void dgvAccs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                /*var accountId = int.Parse(dgvAccs.SelectedRows[0].Cells[0].Value.ToString());
                frmAccountDetails accountDetails = new frmAccountDetails(accountId, _id);*/

                frmAccountDetails accountDetails = new frmAccountDetails(_accounts[e.RowIndex].AccountId, _client);

                accountDetails.Show();
            }
        }

        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            frmAccountDetails accountDetails = new frmAccountDetails(null, _client);
            accountDetails.Show();
        }
    }
}
