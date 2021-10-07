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
    public partial class frmAccountTransactions : Form
    {
        APIService _transactionService = new APIService("Transaction");
        private Account _account = null;
        public frmAccountTransactions(Account account)
        {
            InitializeComponent();
            _account = account;
        }

        private async void frmAccountTransactions_Load(object sender, EventArgs e)
        {

            lblClientName.Text += _account.User.FirstName + " " + _account.User.LastName;
            lblJMBG.Text += _account.User.JMBG;
            lblAccount.Text += _account.AccountNumber.Number;

            var request = new TransactionSearchRequest() { AccountId = _account.AccountId };

            var transactions = await _transactionService.Get<List<Transaction>>(request);

            //lblRemaining.Text += Math.Round(TotalRemaining, 2).ToString() + " " + _loanCurrency;

            dgvTransactions.AutoGenerateColumns = false;

            dgvTransactions.DataSource = transactions.Select(t => new {
                Type = (_account.AccountId == t.SenderId) ? "Outgoing" : "Incoming",
                Amount = (_account.AccountId == t.SenderId) ? "-" + Math.Round(t.Amount, 2).ToString() + " " + _account.Currency.Symbol : "+" + Math.Round(t.CounterAmount, 2).ToString() + " " + _account.Currency.Symbol + " (" + Math.Round(t.Amount, 2).ToString() + t.Sender.Account.Currency.Symbol + ")",
                Participant = (_account.AccountId == t.SenderId) ? "To " + t.Recipient.Number.ToString() : "From " + t.Sender.Number.ToString(),
                Date = t.Date.ToString("dd.MM.yyyy"),
                Description = t.Description
            }).ToList();

            dgvTransactions.Refresh();
        }
    }
}
