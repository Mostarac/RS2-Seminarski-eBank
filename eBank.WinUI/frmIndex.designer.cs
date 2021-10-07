
namespace eBank.WinUI
{
    partial class frmIndex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiClients = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchClients = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoans = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoanApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoanModels = new System.Windows.Forms.ToolStripMenuItem();
            this.loanOverviewReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClients,
            this.tsmiLoans,
            this.profileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(126, 394);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // tsmiClients
            // 
            this.tsmiClients.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSearchClients});
            this.tsmiClients.Name = "tsmiClients";
            this.tsmiClients.Size = new System.Drawing.Size(113, 19);
            this.tsmiClients.Text = "Clients";
            // 
            // tsmiSearchClients
            // 
            this.tsmiSearchClients.Name = "tsmiSearchClients";
            this.tsmiSearchClients.Size = new System.Drawing.Size(109, 22);
            this.tsmiSearchClients.Text = "Search";
            this.tsmiSearchClients.Click += new System.EventHandler(this.tsmiSearchClients_Click);
            // 
            // tsmiLoans
            // 
            this.tsmiLoans.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLoanApplications,
            this.tsmiLoanModels,
            this.loanOverviewReportToolStripMenuItem});
            this.tsmiLoans.Name = "tsmiLoans";
            this.tsmiLoans.Size = new System.Drawing.Size(113, 19);
            this.tsmiLoans.Text = "Loans";
            // 
            // tsmiLoanApplications
            // 
            this.tsmiLoanApplications.Name = "tsmiLoanApplications";
            this.tsmiLoanApplications.Size = new System.Drawing.Size(185, 22);
            this.tsmiLoanApplications.Text = "Loan applications";
            this.tsmiLoanApplications.Click += new System.EventHandler(this.tsmiLoanApplications_Click);
            // 
            // tsmiLoanModels
            // 
            this.tsmiLoanModels.Name = "tsmiLoanModels";
            this.tsmiLoanModels.Size = new System.Drawing.Size(185, 22);
            this.tsmiLoanModels.Text = "Loan models";
            this.tsmiLoanModels.Click += new System.EventHandler(this.tsmiLoanModels_Click);
            // 
            // loanOverviewReportToolStripMenuItem
            // 
            this.loanOverviewReportToolStripMenuItem.Name = "loanOverviewReportToolStripMenuItem";
            this.loanOverviewReportToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.loanOverviewReportToolStripMenuItem.Text = "Loan overview report";
            this.loanOverviewReportToolStripMenuItem.Click += new System.EventHandler(this.loanOverviewReportToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(126, 372);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(557, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.profileToolStripMenuItem.Text = "My profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 394);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmIndex";
            this.Text = "eBank - Employee module";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tsmiClients;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchClients;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoans;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoanApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoanModels;
        private System.Windows.Forms.ToolStripMenuItem loanOverviewReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
    }
}



