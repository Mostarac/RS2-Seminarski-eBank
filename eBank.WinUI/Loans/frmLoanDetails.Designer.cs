
namespace eBank.WinUI.Loans
{
    partial class frmLoanDetails
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtLoanName = new System.Windows.Forms.TextBox();
            this.txtMinPayments = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxPayments = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudInterestRate = new System.Windows.Forms.NumericUpDown();
            this.lblLimit = new System.Windows.Forms.Label();
            this.nudLimit = new System.Windows.Forms.NumericUpDown();
            this.lblLender = new System.Windows.Forms.Label();
            this.cbLenderAcc = new System.Windows.Forms.ComboBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.epLoanDetails = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLoanDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(55, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Loan name";
            // 
            // txtLoanName
            // 
            this.txtLoanName.Location = new System.Drawing.Point(55, 52);
            this.txtLoanName.Name = "txtLoanName";
            this.txtLoanName.Size = new System.Drawing.Size(245, 20);
            this.txtLoanName.TabIndex = 1;
            this.txtLoanName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLoanName_Validating);
            // 
            // txtMinPayments
            // 
            this.txtMinPayments.Location = new System.Drawing.Point(54, 98);
            this.txtMinPayments.Name = "txtMinPayments";
            this.txtMinPayments.Size = new System.Drawing.Size(245, 20);
            this.txtMinPayments.TabIndex = 3;
            this.txtMinPayments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinPayments_KeyPress);
            this.txtMinPayments.Validating += new System.ComponentModel.CancelEventHandler(this.txtMinPayments_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minimum number of payments";
            // 
            // txtMaxPayments
            // 
            this.txtMaxPayments.Location = new System.Drawing.Point(54, 146);
            this.txtMaxPayments.Name = "txtMaxPayments";
            this.txtMaxPayments.Size = new System.Drawing.Size(245, 20);
            this.txtMaxPayments.TabIndex = 5;
            this.txtMaxPayments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxPayments_KeyPress);
            this.txtMaxPayments.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaxPayments_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maximum number of payments";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Interest rate";
            // 
            // nudInterestRate
            // 
            this.nudInterestRate.DecimalPlaces = 2;
            this.nudInterestRate.Location = new System.Drawing.Point(55, 192);
            this.nudInterestRate.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudInterestRate.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.nudInterestRate.Name = "nudInterestRate";
            this.nudInterestRate.Size = new System.Drawing.Size(244, 20);
            this.nudInterestRate.TabIndex = 6;
            this.nudInterestRate.Validating += new System.ComponentModel.CancelEventHandler(this.nudInterestRate_Validating);
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(54, 227);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(28, 13);
            this.lblLimit.TabIndex = 9;
            this.lblLimit.Text = "Limit";
            // 
            // nudLimit
            // 
            this.nudLimit.DecimalPlaces = 2;
            this.nudLimit.Location = new System.Drawing.Point(54, 243);
            this.nudLimit.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudLimit.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.nudLimit.Name = "nudLimit";
            this.nudLimit.Size = new System.Drawing.Size(244, 20);
            this.nudLimit.TabIndex = 8;
            this.nudLimit.Validating += new System.ComponentModel.CancelEventHandler(this.nudLimit_Validating);
            // 
            // lblLender
            // 
            this.lblLender.AutoSize = true;
            this.lblLender.Location = new System.Drawing.Point(54, 275);
            this.lblLender.Name = "lblLender";
            this.lblLender.Size = new System.Drawing.Size(82, 13);
            this.lblLender.TabIndex = 11;
            this.lblLender.Text = "Lender account";
            // 
            // cbLenderAcc
            // 
            this.cbLenderAcc.FormattingEnabled = true;
            this.cbLenderAcc.Location = new System.Drawing.Point(54, 290);
            this.cbLenderAcc.Name = "cbLenderAcc";
            this.cbLenderAcc.Size = new System.Drawing.Size(245, 21);
            this.cbLenderAcc.TabIndex = 10;
            this.cbLenderAcc.Validating += new System.ComponentModel.CancelEventHandler(this.cbLenderAcc_Validating);
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(65, 324);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(220, 13);
            this.lblCurrency.TabIndex = 12;
            this.lblCurrency.Text = "Lender account\'s currency is loan\'s currency!";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 20);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLender);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblCurrency);
            this.groupBox1.Controls.Add(this.txtLoanName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbLenderAcc);
            this.groupBox1.Controls.Add(this.txtMinPayments);
            this.groupBox1.Controls.Add(this.lblLimit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudLimit);
            this.groupBox1.Controls.Add(this.txtMaxPayments);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudInterestRate);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 397);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan details";
            // 
            // epLoanDetails
            // 
            this.epLoanDetails.ContainerControl = this;
            // 
            // frmLoanDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 418);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLoanDetails";
            this.Text = "Loan details";
            this.Load += new System.EventHandler(this.frmLoanDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLoanDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtLoanName;
        private System.Windows.Forms.TextBox txtMinPayments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxPayments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudInterestRate;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.NumericUpDown nudLimit;
        private System.Windows.Forms.Label lblLender;
        private System.Windows.Forms.ComboBox cbLenderAcc;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider epLoanDetails;
    }
}