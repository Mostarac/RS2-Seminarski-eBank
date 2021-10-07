using eBank.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eBank.WinUI.Loans
{
    public partial class frmLoans : Form
    {

        APIService _apiService = new APIService("Loan");
        List<Model.Loan> _loans = new List<Model.Loan>();

        public frmLoans()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new LoanSearchRequest()
            {
                Name = txtSearch.Text
            };

            _loans = await _apiService.Get<List<Model.Loan>>(search);
            dgvLoans.AutoGenerateColumns = false;

            dgvLoans.DataSource = _loans.Select(x=> new { 
                Name=x.Name, 
                Currency = (x.Lender.Currency.Symbol + " " + x.Lender.Currency.CurrencyId), 
                EIR = (x.EIR.ToString() + "%"), 
                Payments = (x.MinPayments.ToString() + " - " + x.MaxPayments.ToString()),
                Limit = x.Limit
            }).ToList();

            dgvLoans.Refresh();
        }

        private void btnNewLoan_Click(object sender, EventArgs e)
        {
            frmLoanDetails frm = new frmLoanDetails(null);
            frm.Show();
        }

        private void dgvLoans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                /*var accountId = int.Parse(dgvAccs.SelectedRows[0].Cells[0].Value.ToString());
                frmAccountDetails accountDetails = new frmAccountDetails(accountId, _id);*/

                frmLoanDetails frm = new frmLoanDetails(_loans[e.RowIndex].LoanId);

                frm.Show();
            }
        }
    }
}
