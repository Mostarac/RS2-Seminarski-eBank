using eBank.Model;
using eBank.Model.Requests;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBank.WinUI.Reports
{
    public partial class frmClientFinanceOverviewReport : Form
    {
        private User _user = null;
        APIService _loanOrderService = new APIService("LoanOrder");
        APIService _accountService = new APIService("Account");
        APIService _transactionService = new APIService("Transaction");
        List<Model.LoanOrder> _loanOrders = new List<Model.LoanOrder>();
        List<Model.Account> _accounts = new List<Model.Account>();
        List<Model.Transaction> _transactions = new List<Model.Transaction>();
        public frmClientFinanceOverviewReport(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private async void frmClientFinanceOverviewReport_Load(object sender, EventArgs e)
        {
            var searchLoanOrders = new LoanOrderSearchRequest() { LoanOrderState = LoanOrderState.Active, UserId = _user.UserId };

            _loanOrders = await _loanOrderService.Get<List<Model.LoanOrder>>(searchLoanOrders);

            ReportParameterCollection rpc = new ReportParameterCollection();

            rpc.Add(new ReportParameter("FullName", _user.FirstName + " " + _user.LastName));
            rpc.Add(new ReportParameter("JMBG", _user.JMBG));

            List<object> sourceList = new List<object>();

            foreach(var x in _loanOrders)
            {
                double r = x.Loan.EIR / 100 / 12; //total effective rate amount per period (month)
                double A = x.Amount * (r * Math.Pow(1 + r, x.Months)) / (Math.Pow(1 + r, x.Months) - 1); //monthly payment rate amount

                string MonthlyRate = Math.Round(A, 2).ToString() + " " + x.Loan.Lender.Currency.CurrencyId;
                sourceList.Add(new { LoanName = x.Loan.Name, MonthlyRate = MonthlyRate });
            }

            var rdsLoans = new ReportDataSource();
            rdsLoans.Name = "dsClientLoans";
            rdsLoans.Value = sourceList;

            List<object> sourceList2 = new List<object>();

            var searchAccounts = new AccountSearchRequest() { UserId = _user.UserId };

            _accounts = await _accountService.Get<List<Model.Account>>(searchAccounts);

            foreach(var a in _accounts)
            {
                var AccN = a.AccountNumber.Number;

                var searchTransactions = new TransactionSearchRequest() { AccountId = a.AccountId };

                var transactions = await _transactionService.Get<List<Model.Transaction>>(searchTransactions);

                var MonthlyIncomingDouble = transactions.Where(x=> x.RecipientId == a.AccountId).Sum(x=>x.CounterAmount);
                var MonthlyOutgoingDouble = transactions.Where(x=> x.SenderId == a.AccountId).Sum(x=>x.Amount);

                var MonthlyIncoming = Math.Round(MonthlyIncomingDouble, 2).ToString() + " " + a.CurrencyId;
                var MonthlyOutgoing = Math.Round(MonthlyOutgoingDouble, 2).ToString() + " " + a.CurrencyId;

                var TotalDouble = MonthlyIncomingDouble - MonthlyOutgoingDouble;
                var Total = Math.Round(TotalDouble, 2).ToString() + " " + a.CurrencyId;

                sourceList2.Add(new { AccountNumber = AccN, MonthlyIncoming = MonthlyIncoming, MonthlyOutgoing = MonthlyOutgoing, MonthlyTotal = Total });

            }

            var rdsLoans2 = new ReportDataSource();
            rdsLoans2.Name = "dsClientAccounts";
            rdsLoans2.Value = sourceList2;

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rdsLoans);
            reportViewer1.LocalReport.DataSources.Add(rdsLoans2);
            this.reportViewer1.RefreshReport();
        }
    }
}
