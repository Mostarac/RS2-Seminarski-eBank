using eBank.WinUI.Clients;
using eBank.WinUI.LoanOrders;
using eBank.WinUI.Loans;
using eBank.WinUI.Reports;
using eBank.WinUI.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eBank.WinUI
{
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;

        public frmIndex()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void tsmiLoanModels_Click(object sender, EventArgs e)
        {
            if(!APIService.IsAdmin) 
            {
                MessageBox.Show("Only administrator can access this module!");
                return;
            }
            frmLoans frm = new frmLoans();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsmiSearchClients_Click(object sender, EventArgs e)
        {
            frmClients frm = new frmClients();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsmiLoanApplications_Click(object sender, EventArgs e)
        {
            frmLoanOrders frm = new frmLoanOrders(null);
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void loanOverviewReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!APIService.IsAdmin)
            {
                MessageBox.Show("Only administrator can access this module!");
                return;
            }
            frmLoanReport frm = new frmLoanReport();
            /*frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;*/
            frm.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails userDetails = new frmUserDetails(APIService.User.UserId);
            userDetails.Show();
        }
    }
}
