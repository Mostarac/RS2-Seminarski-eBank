
namespace eBank.WinUI.LoanOrders
{
    partial class frmLoanOrderApproval
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.lblEIR = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblMonthly = new System.Windows.Forms.Label();
            this.lblPayments = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblLoanName = new System.Windows.Forms.Label();
            this.btnDeny = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblState);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnClient);
            this.groupBox1.Controls.Add(this.lblEIR);
            this.groupBox1.Controls.Add(this.lblComment);
            this.groupBox1.Controls.Add(this.lblMonthly);
            this.groupBox1.Controls.Add(this.lblPayments);
            this.groupBox1.Controls.Add(this.lblTotalInterest);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.lblAccount);
            this.groupBox1.Controls.Add(this.txtComment);
            this.groupBox1.Controls.Add(this.lblLoanName);
            this.groupBox1.Controls.Add(this.btnDeny);
            this.groupBox1.Controls.Add(this.btnApprove);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan approval";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(23, 67);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 15);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Date: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Client\'s details:";
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(131, 38);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(68, 23);
            this.btnClient.TabIndex = 11;
            this.btnClient.Text = "Open";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // lblEIR
            // 
            this.lblEIR.AutoSize = true;
            this.lblEIR.Location = new System.Drawing.Point(22, 119);
            this.lblEIR.Name = "lblEIR";
            this.lblEIR.Size = new System.Drawing.Size(29, 15);
            this.lblEIR.TabIndex = 10;
            this.lblEIR.Text = "EIR: ";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(22, 278);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(99, 15);
            this.lblComment.TabIndex = 9;
            this.lblComment.Text = "Bank\'s comment:";
            // 
            // lblMonthly
            // 
            this.lblMonthly.AutoSize = true;
            this.lblMonthly.Location = new System.Drawing.Point(22, 254);
            this.lblMonthly.Name = "lblMonthly";
            this.lblMonthly.Size = new System.Drawing.Size(58, 15);
            this.lblMonthly.TabIndex = 8;
            this.lblMonthly.Text = "Monthly: ";
            // 
            // lblPayments
            // 
            this.lblPayments.AutoSize = true;
            this.lblPayments.Location = new System.Drawing.Point(22, 226);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(65, 15);
            this.lblPayments.TabIndex = 7;
            this.lblPayments.Text = "Payments: ";
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Location = new System.Drawing.Point(22, 198);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(52, 15);
            this.lblTotalInterest.TabIndex = 6;
            this.lblTotalInterest.Text = "Interest: ";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(23, 171);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(57, 15);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount: ";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(22, 145);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(99, 15);
            this.lblAccount.TabIndex = 4;
            this.lblAccount.Text = "Deposit account: ";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(22, 296);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(412, 23);
            this.txtComment.TabIndex = 3;
            // 
            // lblLoanName
            // 
            this.lblLoanName.AutoSize = true;
            this.lblLoanName.Location = new System.Drawing.Point(22, 92);
            this.lblLoanName.Name = "lblLoanName";
            this.lblLoanName.Size = new System.Drawing.Size(72, 15);
            this.lblLoanName.TabIndex = 2;
            this.lblLoanName.Text = "Loan name: ";
            // 
            // btnDeny
            // 
            this.btnDeny.Location = new System.Drawing.Point(310, 327);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(124, 23);
            this.btnDeny.TabIndex = 1;
            this.btnDeny.Text = "Deny";
            this.btnDeny.UseVisualStyleBackColor = true;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(22, 327);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(126, 23);
            this.btnApprove.TabIndex = 0;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(296, 42);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(39, 15);
            this.lblState.TabIndex = 14;
            this.lblState.Text = "State: ";
            // 
            // frmLoanOrderApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 373);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLoanOrderApproval";
            this.Text = "Loan order approval";
            this.Load += new System.EventHandler(this.frmLoanOrderApproval_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblLoanName;
        private System.Windows.Forms.Button btnDeny;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblMonthly;
        private System.Windows.Forms.Label lblPayments;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblEIR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblState;
    }
}