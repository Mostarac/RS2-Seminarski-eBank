using eBank.Model;
using eBank.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBank.WinUI.LoanOrders
{
    public partial class frmLoanOrders : Form
    {
        APIService _loanOrderService = new APIService("LoanOrder");
        APIService _userService = new APIService("User");
        List<Model.LoanOrder> _loanOrders = new List<Model.LoanOrder>();
        int? _userId = null;
        public frmLoanOrders(int? UserId)
        {
            InitializeComponent();
            if(UserId.HasValue)
            {
                _userId = UserId.Value;
            }

        }

        private async void btnSearchLO_ClickAsync(object sender, EventArgs e)
        {
            var search = new LoanOrderSearchRequest() { };

            if(!_userId.HasValue)
            {
                search.LoanOrderState = LoanOrderState.Ordered;
            }
            else
            {
                /*txtSearchLoanOrder.Hide();
                btnSearchLO.Hide();
                label1.Hide();*/
                //groupBox1.Anchor = AnchorStyles.None;


                //groupBox1.Left = (this.ClientSize.Width - groupBox1.Width) / 2;
                //groupBox1.Top = (this.ClientSize.Height - groupBox1.Height) / 2;

                //groupBox1.Left = (this.Parent.Size.Width - groupBox1.Width) / 2;
                //groupBox1.Top = (this.Parent.Size.Height - groupBox1.Height) / 2;

            }

            var text = txtSearchLoanOrder.Text;

            if (Regex.Match(text, @"^[0-9]{1,13}$").Success)
            {
                search.JMBG = text;
            }
            else
            {
                search.LoanName = text;
            }

            var list = await _loanOrderService.Get<List<Model.LoanOrder>>(search);
            dgvLoanOrders.AutoGenerateColumns = true;

            _loanOrders = list;

            dgvLoanOrders.DataSource = _loanOrders.Select(x=> new { ClientFullName = x.Account.User.FirstName + " " + x.Account.User.LastName, JMBG = x.Account.User.JMBG, LoanModel = x.Loan.Name, State = x.LoanOrderState }).ToList();

            dgvLoanOrders.Refresh();
        }

        private async void frmLoanOrders_Load(object sender, EventArgs e)
        {

            //it's in Load event instead of constructor because PerformClick() won't fire in constructor
            if(_userId.HasValue)
            {
                var user = await _userService.GetById<User>(_userId);

                txtSearchLoanOrder.Text = user.JMBG;
                btnSearchLO.PerformClick();

            }
        }

        private void dgvLoanOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                /*var accountId = int.Parse(dgvAccs.SelectedRows[0].Cells[0].Value.ToString());
                frmAccountDetails accountDetails = new frmAccountDetails(accountId, _id);*/

                LoanOrder selected = _loanOrders[e.RowIndex];

                if(selected.LoanOrderState==LoanOrderState.Ordered)
                {
                    frmLoanOrderApproval loanOrderApproval = new frmLoanOrderApproval(selected);
                    loanOrderApproval.Show();
                }
                else if (selected.LoanOrderState == LoanOrderState.Active)
                {
                    frmLoanOrderDetails loanOrderDetails = new frmLoanOrderDetails(selected);
                    loanOrderDetails.Show();
                }
                else if (selected.LoanOrderState == LoanOrderState.Finished)
                {
                    frmLoanOrderDetails loanOrderDetails = new frmLoanOrderDetails(selected);
                    loanOrderDetails.Show();
                }
                else if (selected.LoanOrderState == LoanOrderState.Denied)
                {
                    frmLoanOrderApproval loanOrderApproval = new frmLoanOrderApproval(selected);
                    loanOrderApproval.Show();
                }
            }
        }
    }
}
