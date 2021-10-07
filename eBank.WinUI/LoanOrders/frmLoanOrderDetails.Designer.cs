
namespace eBank.WinUI.LoanOrders
{
    partial class frmLoanOrderDetails
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
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.lblEIR = new System.Windows.Forms.Label();
            this.lblMonthly = new System.Windows.Forms.Label();
            this.lblPayments = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblLoanName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNextPaymentDue = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(20, 47);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Date: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Client\'s details:";
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(112, 23);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(58, 20);
            this.btnClient.TabIndex = 11;
            this.btnClient.Text = "Open";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // lblEIR
            // 
            this.lblEIR.AutoSize = true;
            this.lblEIR.Location = new System.Drawing.Point(19, 90);
            this.lblEIR.Name = "lblEIR";
            this.lblEIR.Size = new System.Drawing.Size(31, 13);
            this.lblEIR.TabIndex = 10;
            this.lblEIR.Text = "EIR: ";
            // 
            // lblMonthly
            // 
            this.lblMonthly.AutoSize = true;
            this.lblMonthly.Location = new System.Drawing.Point(19, 224);
            this.lblMonthly.Name = "lblMonthly";
            this.lblMonthly.Size = new System.Drawing.Size(50, 13);
            this.lblMonthly.TabIndex = 8;
            this.lblMonthly.Text = "Monthly: ";
            // 
            // lblPayments
            // 
            this.lblPayments.AutoSize = true;
            this.lblPayments.Location = new System.Drawing.Point(19, 202);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(59, 13);
            this.lblPayments.TabIndex = 7;
            this.lblPayments.Text = "Payments: ";
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Location = new System.Drawing.Point(19, 158);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(48, 13);
            this.lblTotalInterest.TabIndex = 6;
            this.lblTotalInterest.Text = "Interest: ";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(20, 136);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(49, 13);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount: ";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(19, 114);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(91, 13);
            this.lblAccount.TabIndex = 4;
            this.lblAccount.Text = "Deposit account: ";
            // 
            // lblLoanName
            // 
            this.lblLoanName.AutoSize = true;
            this.lblLoanName.Location = new System.Drawing.Point(19, 68);
            this.lblLoanName.Name = "lblLoanName";
            this.lblLoanName.Size = new System.Drawing.Size(66, 13);
            this.lblLoanName.TabIndex = 2;
            this.lblLoanName.Text = "Loan name: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNote);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblNextPaymentDue);
            this.groupBox1.Controls.Add(this.lblRemaining);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnClient);
            this.groupBox1.Controls.Add(this.lblEIR);
            this.groupBox1.Controls.Add(this.lblMonthly);
            this.groupBox1.Controls.Add(this.lblPayments);
            this.groupBox1.Controls.Add(this.lblTotalInterest);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.lblAccount);
            this.groupBox1.Controls.Add(this.lblLoanName);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 318);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan order details";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(20, 269);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(36, 13);
            this.lblNote.TabIndex = 17;
            this.lblNote.Text = "Note: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(19, 179);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPayments);
            this.groupBox2.Location = new System.Drawing.Point(375, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 301);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loan order transactions";
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AmountColumn,
            this.DateColumn});
            this.dgvPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayments.Location = new System.Drawing.Point(3, 16);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowTemplate.Height = 25;
            this.dgvPayments.Size = new System.Drawing.Size(283, 282);
            this.dgvPayments.TabIndex = 0;
            // 
            // AmountColumn
            // 
            this.AmountColumn.DataPropertyName = "Amount";
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            this.AmountColumn.Width = 120;
            // 
            // DateColumn
            // 
            this.DateColumn.DataPropertyName = "Date";
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            this.DateColumn.Width = 120;
            // 
            // lblNextPaymentDue
            // 
            this.lblNextPaymentDue.AutoSize = true;
            this.lblNextPaymentDue.Location = new System.Drawing.Point(20, 292);
            this.lblNextPaymentDue.Name = "lblNextPaymentDue";
            this.lblNextPaymentDue.Size = new System.Drawing.Size(99, 13);
            this.lblNextPaymentDue.TabIndex = 15;
            this.lblNextPaymentDue.Text = "Next payment due: ";
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Location = new System.Drawing.Point(20, 246);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(95, 13);
            this.lblRemaining.TabIndex = 14;
            this.lblRemaining.Text = "Remaining to pay: ";
            // 
            // frmLoanOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 339);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLoanOrderDetails";
            this.Text = "Loan order details";
            this.Load += new System.EventHandler(this.frmLoanOrderDetails_LoadAsync);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Label lblEIR;
        private System.Windows.Forms.Label lblMonthly;
        private System.Windows.Forms.Label lblPayments;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblLoanName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label lblNextPaymentDue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
    }
}