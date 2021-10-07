using eBank.Model;
using eBank.Model.Requests;
using eBank.WinUI.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBank.WinUI.LoanOrders
{
    public partial class frmLoanOrderApproval : Form
    {
        APIService _loanOrderService = new APIService("LoanOrder");
        private LoanOrder _loanOrder = null;
        public frmLoanOrderApproval(LoanOrder loanOrder)
        {
            InitializeComponent();
            _loanOrder = loanOrder;
        }

        private void frmLoanOrderApproval_Load(object sender, EventArgs e)
        {
            if(_loanOrder.LoanOrderState == LoanOrderState.Denied)
            {
                txtComment.Visible = false;
                btnApprove.Visible = false;
                btnDeny.Visible = false;
                lblComment.Text += _loanOrder.Comment;
            }

            lblState.Text += _loanOrder.LoanOrderState;
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

            double TotalDouble = A * N;
            string Total = Math.Round(TotalDouble, 2).ToString() + " " + _loanOrder.Loan.Lender.Currency.CurrencyId;
            string TotalInterest = Math.Round((TotalDouble - P), 2).ToString() + " " + _loanOrder.Loan.Lender.Currency.CurrencyId;
            string MonthlyRate = Math.Round(A, 2).ToString() + " " + _loanOrder.Loan.Lender.Currency.CurrencyId;

            lblMonthly.Text += MonthlyRate;
            lblPayments.Text += _loanOrder.Months.ToString();
            lblTotalInterest.Text += TotalInterest;

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            frmClientDetails clientDetails = new frmClientDetails(_loanOrder.Account.User);
            clientDetails.Show();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            Process(LoanOrderState.Active);

        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            Process(LoanOrderState.Denied);
        }

        private async void Process(LoanOrderState state)
        {
            LoanOrderUpsertRequest request = new LoanOrderUpsertRequest()
            {
                LoanId = _loanOrder.LoanId,
                AccountId = _loanOrder.AccountId,
                Amount = _loanOrder.Amount,
                Months = _loanOrder.Months,
                Comment = txtComment.Text,
                LoanOrderState = LoanOrderState.Active,
                CreationDate = DateTime.Now
            };

            Model.LoanOrder entity = await _loanOrderService.Update<Model.LoanOrder>(_loanOrder.LoanOrderId, request);

            if (entity != null)
            {
                if(state == LoanOrderState.Active)
                {
                    MessageBox.Show("Successfully approved!");
                }
                else
                {
                    MessageBox.Show("Successfully denied!");
                }
                
            }
            else
            {
                if (state == LoanOrderState.Active)
                {
                    MessageBox.Show("Error approving the loan order!");
                }
                else
                {
                    MessageBox.Show("Error denying the loan order!");
                }
            }

            this.Close();
        }

    }
}
