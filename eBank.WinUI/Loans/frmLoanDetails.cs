using eBank.Model;
using eBank.Model.Requests;
using eBank.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace eBank.WinUI.Loans
{
    public partial class frmLoanDetails : Form
    {
        APIService _accountService = new APIService("Account");
        APIService _loanService = new APIService("Loan");
        List<Account> _accounts = new List<Account>();

        private int? _loanId = null;
        public frmLoanDetails(int? loanId)
        {
            InitializeComponent();
            _loanId = loanId;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {

                if(int.Parse(txtMaxPayments.Text) < int.Parse(txtMinPayments.Text))
                {
                    MessageBox.Show("Number of maximum payments must be bigger than minimum payments!");
                    return;
                }

                var request = new LoanUpsertRequest
                {
                    Name = txtLoanName.Text,
                    MinPayments = int.Parse(txtMinPayments.Text),
                    MaxPayments = int.Parse(txtMaxPayments.Text),
                    EIR = (double)nudInterestRate.Value,
                    Limit = (double)nudLimit.Value,
                    LenderId = (int)cbLenderAcc.SelectedValue

                };

                Model.Loan entity = null;
                if (!_loanId.HasValue)
                {
                    entity = await _loanService.Insert<Model.Loan>(request);
                }
                else
                {
                    entity = await _loanService.Update<Model.Loan>(_loanId.Value, request);
                }

                if (entity != null)
                {
                    MessageBox.Show("Success");
                }
            }
        }

        private async void frmLoanDetails_Load(object sender, EventArgs e)
        {
            var request = new AccountSearchRequest() { UserId = APIService.User.UserId };

            var accounts = await _accountService.Get<List<Model.Account>>(request);

            /*
            cbLenderAcc.DataSource = accounts;
            cbLenderAcc.DisplayMember = nameof(AccountNumber.Number);
            cbLenderAcc.ValueMember = "AccountId";
            */

            cbLenderAcc.DataSource = accounts.Select(x=> new { Number = x.CurrencyId + " - " + x.AccountNumber.Number, AccountId = x.AccountId }).ToList();
            cbLenderAcc.DisplayMember = "Number";
            cbLenderAcc.ValueMember = "AccountId";

            if (_loanId.HasValue)
            {

                var entity = await _loanService.GetById<Model.Loan>(_loanId);

                txtLoanName.Text = entity.Name;
                txtMaxPayments.Text = entity.MaxPayments.ToString();
                txtMinPayments.Text = entity.MinPayments.ToString();
                cbLenderAcc.SelectedValue = entity.LenderId;
                nudInterestRate.Value = (decimal)entity.EIR;
                nudLimit.Value = (decimal)entity.Limit;

            }

        }

        private void txtLoanName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLoanName.Text))
            {
                e.Cancel = true;
                epLoanDetails.SetError(txtLoanName, Resources.Validation_RequiredField);
            }
            else
            {
                epLoanDetails.SetError(txtLoanName, null);
            }
        }

        private void txtMinPayments_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMinPayments.Text))
            {
                e.Cancel = true;
                epLoanDetails.SetError(txtMinPayments, Resources.Validation_RequiredField);
            }
            else if (!Regex.Match(txtMinPayments.Text, @"^[0-9]{1,3}$").Success)
            {
                e.Cancel = true;
                epLoanDetails.SetError(txtMinPayments, "Min payments must be between 1 and 360");
            }
            else
            {
                int MinPayments = int.Parse(txtMinPayments.Text);
                if (MinPayments < 1 || MinPayments > 360)
                {
                    e.Cancel = true;
                    epLoanDetails.SetError(txtMinPayments, "Min payments must be between 1 and 360");
                }
                else
                {
                    epLoanDetails.SetError(txtMinPayments, null);
                }
                
            }
        }

        private void txtMaxPayments_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaxPayments.Text))
            {
                e.Cancel = true;
                epLoanDetails.SetError(txtMaxPayments, Resources.Validation_RequiredField);
            }
            else if (!Regex.Match(txtMaxPayments.Text, @"^[0-9]{1,3}$").Success)
            {
                e.Cancel = true;
                epLoanDetails.SetError(txtMaxPayments, "Must contain 13 numbers only");
            }
            else
            {
                int MaxPayments = int.Parse(txtMaxPayments.Text);
                if (MaxPayments < 1 || MaxPayments > 360)
                {
                    e.Cancel = true;
                    epLoanDetails.SetError(txtMaxPayments, "Max payments must be between 1 and 360");
                }
                else
                {
                    epLoanDetails.SetError(txtMaxPayments, null);
                }
            }
        }

        private void nudInterestRate_Validating(object sender, CancelEventArgs e)
        {
            if (nudInterestRate.Value <= 0 || nudInterestRate.Value > 100)
            {
                e.Cancel = true;
                epLoanDetails.SetError(nudInterestRate, "Interest rate must be between 0 and 100!");
            }
            else
            {
                epLoanDetails.SetError(nudInterestRate, null);
            }
        }

        private void nudLimit_Validating(object sender, CancelEventArgs e)
        {
            if (nudLimit.Value <= 0)
            {
                e.Cancel = true;
                epLoanDetails.SetError(nudLimit, "Limit must be greater than 0!");
            }
            else
            {
                epLoanDetails.SetError(nudLimit, null);
            }
        }

        private void cbLenderAcc_Validating(object sender, CancelEventArgs e)
        {
            if (cbLenderAcc.SelectedItem == null)
            {
                e.Cancel = true;
                epLoanDetails.SetError(cbLenderAcc, Resources.Validation_RequiredField);
            }
            else
            {
                epLoanDetails.SetError(cbLenderAcc, null);
            }
        }

        private void txtMinPayments_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMaxPayments_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
