
namespace eBank.WinUI.Clients
{
    partial class frmClientDetails
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
            this.pnlUserDetails = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFinanceReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowLoans = new System.Windows.Forms.Button();
            this.btnShowAccounts = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUserDetails
            // 
            this.pnlUserDetails.Location = new System.Drawing.Point(3, 114);
            this.pnlUserDetails.Name = "pnlUserDetails";
            this.pnlUserDetails.Size = new System.Drawing.Size(509, 491);
            this.pnlUserDetails.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFinanceReport);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnShowLoans);
            this.groupBox1.Controls.Add(this.btnShowAccounts);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account details";
            // 
            // btnFinanceReport
            // 
            this.btnFinanceReport.Location = new System.Drawing.Point(346, 51);
            this.btnFinanceReport.Name = "btnFinanceReport";
            this.btnFinanceReport.Size = new System.Drawing.Size(95, 26);
            this.btnFinanceReport.TabIndex = 4;
            this.btnFinanceReport.Text = "Finance report";
            this.btnFinanceReport.UseVisualStyleBackColor = true;
            this.btnFinanceReport.Click += new System.EventHandler(this.btnFinanceReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Show user\'s:";
            // 
            // btnShowLoans
            // 
            this.btnShowLoans.Location = new System.Drawing.Point(198, 51);
            this.btnShowLoans.Name = "btnShowLoans";
            this.btnShowLoans.Size = new System.Drawing.Size(97, 26);
            this.btnShowLoans.TabIndex = 1;
            this.btnShowLoans.Text = "Loans";
            this.btnShowLoans.UseVisualStyleBackColor = true;
            this.btnShowLoans.Click += new System.EventHandler(this.btnShowLoans_Click);
            // 
            // btnShowAccounts
            // 
            this.btnShowAccounts.Location = new System.Drawing.Point(47, 51);
            this.btnShowAccounts.Name = "btnShowAccounts";
            this.btnShowAccounts.Size = new System.Drawing.Size(105, 26);
            this.btnShowAccounts.TabIndex = 0;
            this.btnShowAccounts.Text = "Accounts";
            this.btnShowAccounts.UseVisualStyleBackColor = true;
            this.btnShowAccounts.Click += new System.EventHandler(this.btnShowAccounts_Click);
            // 
            // frmClientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 617);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlUserDetails);
            this.Name = "frmClientDetails";
            this.Text = "Person details";
            this.Load += new System.EventHandler(this.frmClientDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUserDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnShowAccounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowLoans;
        private System.Windows.Forms.Button btnFinanceReport;
    }
}