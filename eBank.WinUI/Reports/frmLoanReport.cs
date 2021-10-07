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
    public partial class frmLoanReport : Form
    {
        APIService _loanOrderService = new APIService("LoanOrder");
        APIService _transactionService = new APIService("Transaction");
        public frmLoanReport()
        {
            InitializeComponent();
        }

        private void frmLoanReport_Load(object sender, EventArgs e)
        {
            nudTo.Value = 10000000;
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            double FromAmount = (double)nudFrom.Value;
            double ToAmount = (double)nudTo.Value;

            if(FromAmount > ToAmount)
            {
                MessageBox.Show("You have entered invalid amount range!");
            }

            var searchLoanOrders = new LoanOrderSearchRequest() { LoanOrderState = LoanOrderState.Active };

            var loanOrders = await _loanOrderService.Get<List<Model.LoanOrder>>(searchLoanOrders);

            ReportParameterCollection rpc = new ReportParameterCollection();

            rpc.Add(new ReportParameter("FromAmount", FromAmount.ToString()));
            rpc.Add(new ReportParameter("ToAmount", ToAmount.ToString()));

            List<object> sourceList = new List<object>();

            foreach (var x in loanOrders)
            {
                string _loanCurrency = x.Loan.Lender.CurrencyId;

                double A; //monthly payment rate amount
                double P = x.Amount; //loan amount
                int N = x.Months; //number of months
                double r = x.Loan.EIR / 100 / 12; //total effective rate amount per period (month)

                A = P * (r * Math.Pow(1 + r, N)) / (Math.Pow(1 + r, N) - 1);

                double MonthlyRateDouble = A;
                double TotalDouble = A * N;
                if(TotalDouble < FromAmount || TotalDouble > ToAmount)
                {
                    continue;
                }
                string Total = Math.Round(TotalDouble, 2).ToString() + " " + _loanCurrency;
                string TotalInterest = Math.Round((TotalDouble - P), 2).ToString() + " " + _loanCurrency;
                string MonthlyRate = Math.Round(A, 2).ToString() + " " + _loanCurrency;

                var transactionRequest = new TransactionSearchRequest() { LoanOrderId = x.LoanOrderId };
                var transactions = await _transactionService.Get<List<Transaction>>(transactionRequest);

                var TotalPaid = transactions.Sum(a => a.Amount);

                var TotalTransactions = transactions.Count();

                var TotalRemaining = TotalDouble - TotalPaid;

                var AverageMonthlyPayment = Math.Round(TotalPaid / TotalTransactions, 2).ToString() + " " + _loanCurrency;

                var AverageExtraPaid = Math.Round(((TotalPaid / TotalTransactions) - MonthlyRateDouble), 2).ToString() + " " + _loanCurrency;

                var TotalRemainingString = Math.Round(TotalRemaining, 2).ToString() + " " + _loanCurrency;
                sourceList.Add(new { LoanName = x.Loan.Name, ClientName = x.Account.User.FirstName + " " + x.Account.User.LastName,  Total = Total, NumberOfPayments = x.Months.ToString(), RemainingPayments = ((int)Math.Floor(TotalPaid / MonthlyRateDouble)).ToString(), MonthlyPayment = MonthlyRate, AverageMonthlyPayment = AverageMonthlyPayment, AverageExtraPaid = AverageExtraPaid  });
            }

            var rdsLoans = new ReportDataSource();
            rdsLoans.Name = "dsLoansOverview";
            rdsLoans.Value = sourceList;

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rdsLoans);
            this.reportViewer1.RefreshReport();

        }
    }
}
