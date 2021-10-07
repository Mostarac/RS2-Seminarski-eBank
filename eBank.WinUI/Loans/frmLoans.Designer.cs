
namespace eBank.WinUI.Loans
{
    partial class frmLoans
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnNewLoan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.columnLoanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPayments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLoans);
            this.groupBox1.Location = new System.Drawing.Point(9, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loans";
            // 
            // dgvLoans
            // 
            this.dgvLoans.AllowUserToAddRows = false;
            this.dgvLoans.AllowUserToDeleteRows = false;
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnLoanName,
            this.columnCurrency,
            this.columnEIR,
            this.columnPayments,
            this.columnLimit,
            this.columnDetails});
            this.dgvLoans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoans.Location = new System.Drawing.Point(3, 16);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.ReadOnly = true;
            this.dgvLoans.RowTemplate.Height = 25;
            this.dgvLoans.Size = new System.Drawing.Size(594, 205);
            this.dgvLoans.TabIndex = 0;
            this.dgvLoans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoans_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(493, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 20);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(52, 49);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(366, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnNewLoan
            // 
            this.btnNewLoan.Location = new System.Drawing.Point(493, 342);
            this.btnNewLoan.Name = "btnNewLoan";
            this.btnNewLoan.Size = new System.Drawing.Size(64, 20);
            this.btnNewLoan.TabIndex = 3;
            this.btnNewLoan.Text = "New loan";
            this.btnNewLoan.UseVisualStyleBackColor = true;
            this.btnNewLoan.Click += new System.EventHandler(this.btnNewLoan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search loan models by name:";
            // 
            // columnLoanName
            // 
            this.columnLoanName.DataPropertyName = "Name";
            this.columnLoanName.HeaderText = "Name";
            this.columnLoanName.Name = "columnLoanName";
            this.columnLoanName.ReadOnly = true;
            // 
            // columnCurrency
            // 
            this.columnCurrency.DataPropertyName = "Currency";
            this.columnCurrency.HeaderText = "Currency";
            this.columnCurrency.Name = "columnCurrency";
            this.columnCurrency.ReadOnly = true;
            this.columnCurrency.Width = 90;
            // 
            // columnEIR
            // 
            this.columnEIR.DataPropertyName = "EIR";
            dataGridViewCellStyle3.NullValue = null;
            this.columnEIR.DefaultCellStyle = dataGridViewCellStyle3;
            this.columnEIR.HeaderText = "Interest rate";
            this.columnEIR.Name = "columnEIR";
            this.columnEIR.ReadOnly = true;
            this.columnEIR.Width = 90;
            // 
            // columnPayments
            // 
            this.columnPayments.DataPropertyName = "Payments";
            this.columnPayments.HeaderText = "Payments";
            this.columnPayments.Name = "columnPayments";
            this.columnPayments.ReadOnly = true;
            this.columnPayments.Width = 90;
            // 
            // columnLimit
            // 
            this.columnLimit.DataPropertyName = "Limit";
            this.columnLimit.HeaderText = "Limit";
            this.columnLimit.Name = "columnLimit";
            this.columnLimit.ReadOnly = true;
            this.columnLimit.Width = 90;
            // 
            // columnDetails
            // 
            this.columnDetails.HeaderText = "Details";
            this.columnDetails.Name = "columnDetails";
            this.columnDetails.ReadOnly = true;
            this.columnDetails.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnDetails.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnDetails.Text = "Open";
            this.columnDetails.UseColumnTextForButtonValue = true;
            this.columnDetails.Width = 90;
            // 
            // frmLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewLoan);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLoans";
            this.Text = "Loans";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.Button btnNewLoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLoanName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLimit;
        private System.Windows.Forms.DataGridViewButtonColumn columnDetails;
    }
}