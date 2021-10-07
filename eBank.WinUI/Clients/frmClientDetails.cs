using eBank.Model;
using eBank.WinUI.Accounts;
using eBank.WinUI.LoanOrders;
using eBank.WinUI.Reports;
using eBank.WinUI.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eBank.WinUI.Clients
{
    public partial class frmClientDetails : Form
    {
        private User _client;

        public frmClientDetails(User client)
        {
            InitializeComponent();

            _client = client;
        }

        private void frmClientDetails_Load(object sender, EventArgs e)
        {
            frmUserDetails userDetails = new frmUserDetails(_client.UserId) { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.pnlUserDetails.Controls.Add(userDetails);
            userDetails.Show();
        }

        private void btnShowAccounts_Click(object sender, EventArgs e)
        {

            //CheckAndRemoveControlsFromPanel();

            frmAccounts accounts = new frmAccounts(_client);

            //this.pnlAccountDetails.Controls.Add(accounts);
            accounts.Show();

        }

        private void btnShowLoans_Click(object sender, EventArgs e)
        {

            //CheckAndRemoveControlsFromPanel();

            frmLoanOrders loanOrders = new frmLoanOrders(_client.UserId);
            //this.pnlAccountDetails.Controls.Add(loanOrders);
            loanOrders.Show();
        }

        private void btnFinanceReport_Click(object sender, EventArgs e)
        {
            frmClientFinanceOverviewReport frm = new frmClientFinanceOverviewReport(_client);
            frm.Show();
        }

        /*private void CheckAndRemoveControlsFromPanel()
        {
            var accControl = this.pnlAccountDetails.Controls.Find(nameof(frmAccounts), true);
            if (accControl.Length > 0)
            {
                this.pnlAccountDetails.Controls.Remove(accControl[0]);
            }

            var loanControl = this.pnlAccountDetails.Controls.Find(nameof(frmLoanOrders), true);
            if (loanControl.Length > 0)
            {
                this.pnlAccountDetails.Controls.Remove(loanControl[0]);
            }
        }*/

    }
}
