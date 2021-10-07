
namespace eBank.WinUI.Accounts
{
    partial class frmAccountDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.btnSaveAccDetails = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudLimit = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudBalance = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAccType = new System.Windows.Forms.ComboBox();
            this.epAccountDetails = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblClientJMBG = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.btnTransactionHistory = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAccountDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAccountNumber);
            this.groupBox1.Controls.Add(this.btnSaveAccDetails);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudLimit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudBalance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbCurrency);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbAccType);
            this.groupBox1.Location = new System.Drawing.Point(10, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account details";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(33, 42);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(50, 13);
            this.lblAccountNumber.TabIndex = 9;
            this.lblAccountNumber.Text = "Number: ";
            // 
            // btnSaveAccDetails
            // 
            this.btnSaveAccDetails.Location = new System.Drawing.Point(109, 287);
            this.btnSaveAccDetails.Name = "btnSaveAccDetails";
            this.btnSaveAccDetails.Size = new System.Drawing.Size(91, 22);
            this.btnSaveAccDetails.TabIndex = 8;
            this.btnSaveAccDetails.Text = "Save";
            this.btnSaveAccDetails.UseVisualStyleBackColor = true;
            this.btnSaveAccDetails.Click += new System.EventHandler(this.btnSaveAccDetails_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Limit";
            // 
            // nudLimit
            // 
            this.nudLimit.DecimalPlaces = 2;
            this.nudLimit.Location = new System.Drawing.Point(33, 246);
            this.nudLimit.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudLimit.Name = "nudLimit";
            this.nudLimit.Size = new System.Drawing.Size(244, 20);
            this.nudLimit.TabIndex = 6;
            this.nudLimit.Validating += new System.ComponentModel.CancelEventHandler(this.nudLimit_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Balance";
            // 
            // nudBalance
            // 
            this.nudBalance.DecimalPlaces = 2;
            this.nudBalance.Location = new System.Drawing.Point(33, 192);
            this.nudBalance.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudBalance.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.nudBalance.Name = "nudBalance";
            this.nudBalance.Size = new System.Drawing.Size(244, 20);
            this.nudBalance.TabIndex = 4;
            this.nudBalance.Validating += new System.ComponentModel.CancelEventHandler(this.nudBalance_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Currency";
            // 
            // cbCurrency
            // 
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Location = new System.Drawing.Point(33, 142);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(245, 21);
            this.cbCurrency.TabIndex = 2;
            this.cbCurrency.Validating += new System.ComponentModel.CancelEventHandler(this.cbCurrency_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type";
            // 
            // cbAccType
            // 
            this.cbAccType.FormattingEnabled = true;
            this.cbAccType.Location = new System.Drawing.Point(33, 87);
            this.cbAccType.Name = "cbAccType";
            this.cbAccType.Size = new System.Drawing.Size(245, 21);
            this.cbAccType.TabIndex = 0;
            this.cbAccType.Validating += new System.ComponentModel.CancelEventHandler(this.cbAccType_Validating);
            // 
            // epAccountDetails
            // 
            this.epAccountDetails.ContainerControl = this;
            // 
            // lblClientJMBG
            // 
            this.lblClientJMBG.AutoSize = true;
            this.lblClientJMBG.Location = new System.Drawing.Point(10, 32);
            this.lblClientJMBG.Name = "lblClientJMBG";
            this.lblClientJMBG.Size = new System.Drawing.Size(42, 13);
            this.lblClientJMBG.TabIndex = 4;
            this.lblClientJMBG.Text = "JMBG: ";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(10, 16);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(39, 13);
            this.lblClientName.TabIndex = 3;
            this.lblClientName.Text = "Client: ";
            // 
            // btnTransactionHistory
            // 
            this.btnTransactionHistory.Location = new System.Drawing.Point(211, 25);
            this.btnTransactionHistory.Name = "btnTransactionHistory";
            this.btnTransactionHistory.Size = new System.Drawing.Size(105, 26);
            this.btnTransactionHistory.TabIndex = 5;
            this.btnTransactionHistory.Text = "Transaction history";
            this.btnTransactionHistory.UseVisualStyleBackColor = true;
            this.btnTransactionHistory.Click += new System.EventHandler(this.btnTransactionHistory_Click);
            // 
            // frmAccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 391);
            this.Controls.Add(this.btnTransactionHistory);
            this.Controls.Add(this.lblClientJMBG);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAccountDetails";
            this.Text = "Account details";
            this.Load += new System.EventHandler(this.frmAccountDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAccountDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.NumericUpDown nudBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveAccDetails;
        private System.Windows.Forms.ComboBox cbAccType;
        private System.Windows.Forms.NumericUpDown nudLimit;
        private System.Windows.Forms.ErrorProvider errorProviderAccountDetails;
        private System.Windows.Forms.ErrorProvider epAccountDetails;
        private System.Windows.Forms.Label lblClientJMBG;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Button btnTransactionHistory;
    }
}