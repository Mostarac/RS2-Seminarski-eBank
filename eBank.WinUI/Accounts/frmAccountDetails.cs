using eBank.Model;
using eBank.Model.Requests;
using eBank.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eBank.WinUI.Accounts
{
    public partial class frmAccountDetails : Form
    {
        APIService _accountTypeService = new APIService("AccountType");
        APIService _currencyService = new APIService("Currency");
        APIService _accountService = new APIService("Account");
        List<AccountType> _accountTypes = new List<AccountType>();
        List<Currency> _currencies = new List<Currency>();
        Account entity = null;

        private int? _accountId = null;
        private User _client;
        public frmAccountDetails(int? accountId, User client)
        {
            InitializeComponent();
            _accountId = accountId;
            _client = client;
        }

        private async void frmAccountDetails_Load(object sender, EventArgs e)
        {
            btnTransactionHistory.Visible = false;
            var currencies = await _currencyService.Get<List<Model.Currency>>(null);
            var accountTypes = await _accountTypeService.Get<List<Model.AccountType>>(null);

            cbCurrency.DataSource = currencies;
            cbCurrency.DisplayMember = "Name";
            cbCurrency.ValueMember = "CurrencyId";

            cbAccType.DataSource = accountTypes;
            cbAccType.DisplayMember = "Name";
            cbAccType.ValueMember = "AccountTypeId";

            lblClientName.Text += _client.FirstName + " " + _client.LastName;
            lblClientJMBG.Text += _client.JMBG;
            

            if (_accountId.HasValue)
            {
                entity = await _accountService.GetById<Model.Account>(_accountId);

                btnTransactionHistory.Visible = true;

                cbCurrency.SelectedValue = entity.CurrencyId;
                cbAccType.SelectedValue = entity.AccountTypeId;
                nudBalance.Value = (decimal)entity.Balance;
                nudLimit.Value = (decimal)entity.Limit;
                lblAccountNumber.Text += entity.AccountNumber.Number;
            }
            else
            {
                lblAccountNumber.Text += "will be auto generated";
            }
        }

        private void cbAccType_Validating(object sender, CancelEventArgs e)
        {
            if (cbAccType.SelectedItem == null)
            {
                e.Cancel = true;
                epAccountDetails.SetError(cbAccType, Resources.Validation_RequiredField);
            }
            else
            {
                epAccountDetails.SetError(cbAccType, null);
            }
        }

        private void cbCurrency_Validating(object sender, CancelEventArgs e)
        {
            if (cbCurrency.SelectedItem == null)
            {
                e.Cancel = true;
                epAccountDetails.SetError(cbCurrency, Resources.Validation_RequiredField);
            }
            else
            {
                epAccountDetails.SetError(cbCurrency, null);
            }
        }

        private void nudBalance_Validating(object sender, CancelEventArgs e)
        {
            if (nudBalance.Value < (0-nudLimit.Value))
            {
                e.Cancel = true;
                epAccountDetails.SetError(nudBalance, "Can't set balance below limit");
            }
            else
            {
                epAccountDetails.SetError(nudBalance, null);
            }
        }

        private void nudLimit_Validating(object sender, CancelEventArgs e)
        {
            if (nudLimit.Value > 5000 || nudLimit.Value < 0)
            {
                e.Cancel = true;
                epAccountDetails.SetError(nudLimit, "Can't set limit higher than 5000 or lower than 0");
            }
            else
            {
                epAccountDetails.SetError(nudLimit, null);
            }
        }

        private async void btnSaveAccDetails_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = new AccountUpsertRequest
                {
                    CurrencyId = (string)cbCurrency.SelectedValue,
                    AccountTypeId = (int)cbAccType.SelectedValue,
                    Balance = (double)nudBalance.Value,
                    Limit = (double)nudLimit.Value,
                    UserId = _client.UserId

                };

                Model.Account entity = null;
                if (!_accountId.HasValue)
                {
                    entity = await _accountService.Insert<Model.Account>(request);
                }
                else
                {
                    entity = await _accountService.Update<Model.Account>(_accountId.Value, request);
                }

                if (entity != null)
                {
                    MessageBox.Show("Success");
                }
            }
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            frmAccountTransactions frm = new frmAccountTransactions(entity);
            frm.Show();
        }
    }
}
