using eBank.Model;
using eBank.Model.Requests;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eBank.WinUI.Clients;

namespace eBank.WinUI.LoanOrders
{
    public partial class frmLoanOrderDetails : Form
    {
        APIService _transactionService = new APIService("Transaction");
        private LoanOrder _loanOrder = null;
        public frmLoanOrderDetails(LoanOrder loanOrder)
        {
            InitializeComponent();
            _loanOrder = loanOrder;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            frmClientDetails clientDetails = new frmClientDetails(_loanOrder.Account.User);
            clientDetails.Show();
        }

        private async void frmLoanOrderDetails_LoadAsync(object sender, EventArgs e)
        {
            string _loanCurrency = _loanOrder.Loan.Lender.CurrencyId;
            lblAccount.Text += _loanOrder.Account.AccountNumber.Number;
            lblAmount.Text += _loanOrder.Amount.ToString();
            lblEIR.Text += _loanOrder.Loan.EIR.ToString() + "%";
            lblLoanName.Text += _loanOrder.Loan.Name;
            lblDate.Text += _loanOrder.CreationDate.ToString("dd/MM/yyyy");

            double A; //monthly payment rate amount
            double P = _loanOrder.Amount; //loan amount
            int N = _loanOrder.Months; //number of months
            double r = _loanOrder.Loan.EIR / 100 / 12; //total effective rate amount per period (month)

            A = P * (r * Math.Pow(1 + r, N)) / (Math.Pow(1 + r, N) - 1);

            double MonthlyRateDouble = A;
            double TotalDouble = A * N;
            string Total = Math.Round(TotalDouble, 2).ToString() + " " + _loanCurrency;
            string TotalInterest = Math.Round((TotalDouble - P), 2).ToString() + " " + _loanCurrency;
            string MonthlyRate = Math.Round(A, 2).ToString() + " " + _loanCurrency;

            lblMonthly.Text += MonthlyRate;
            lblPayments.Text += _loanOrder.Months.ToString();
            lblTotalInterest.Text += TotalInterest;

            var request = new TransactionSearchRequest() { LoanOrderId = _loanOrder.LoanOrderId };

            var transactions = await _transactionService.Get<List<Transaction>>(request);

            var TotalPaid = transactions.Sum(x => x.Amount);

            var TotalRemaining = TotalDouble - TotalPaid;

            lblRemaining.Text += Math.Round(TotalRemaining, 2).ToString() + " " + _loanCurrency;

            dgvPayments.AutoGenerateColumns = false;

            dgvPayments.DataSource = transactions.Select(x=> new { Amount = Math.Round(x.Amount, 2).ToString() + " " + x.Recipient.Account.CurrencyId, Date = x.Date.ToString("dd/MM/yyyy") }).ToList();

            dgvPayments.Refresh();

            var IsActive = _loanOrder.LoanOrderState == LoanOrderState.Active;

            //Logic to show warning to client in case he/she is late with payments
            //First we calculate how many months have passed from loan order date

            DateTime firstDate = _loanOrder.CreationDate;
            DateTime secondDate = DateTime.Now;

            int m1 = (secondDate.Month - firstDate.Month);//for years
            int m2 = (secondDate.Year - firstDate.Year) * 12; //for months
            int MonthsPassed = m1 + m2;

            if (IsActive == false)
            {
                lblNote.Text = "Loan has been fully paid off";
                lblNextPaymentDue.Text = "";
            }
            else
            {
                //We set NextPaymentDue here
                lblNextPaymentDue.Text = "Next payment due: " + firstDate.AddMonths(((int)Math.Floor(TotalPaid / MonthlyRateDouble)) + 1).ToString("dd/MM/yyyy");

                //Then we multiply that number of months with monthly payment rate
                var ShouldHavePaid = MonthsPassed * MonthlyRateDouble;

                //Display warning if the paid off amount is less than it should be by that date
                if (TotalPaid < ShouldHavePaid)
                {
                    lblNote.Text = "Warning: you are missing payment amount of" + (ShouldHavePaid - TotalPaid).ToString() + " " + _loanCurrency;
                }
                else
                {
                    lblNote.Text = "You are on time with your payments";
                    if (TotalPaid > ShouldHavePaid)
                    {
                        lblNote.Text += " with " + Math.Round((TotalPaid - ShouldHavePaid), 2).ToString() + " " + _loanCurrency + " paid forward";
                    }
                }
            }

        }
    }
}
