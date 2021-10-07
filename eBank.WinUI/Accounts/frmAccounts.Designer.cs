
namespace eBank.WinUI.Accounts
{
    partial class frmAccounts
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
            this.btnNewAcc = new System.Windows.Forms.Button();
            this.dgvAccs = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblClientJMBG = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccs)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNewAcc);
            this.groupBox1.Controls.Add(this.dgvAccs);
            this.groupBox1.Location = new System.Drawing.Point(23, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accounts";
            // 
            // btnNewAcc
            // 
            this.btnNewAcc.Location = new System.Drawing.Point(351, 245);
            this.btnNewAcc.Name = "btnNewAcc";
            this.btnNewAcc.Size = new System.Drawing.Size(105, 24);
            this.btnNewAcc.TabIndex = 1;
            this.btnNewAcc.Text = "New account";
            this.btnNewAcc.UseVisualStyleBackColor = true;
            this.btnNewAcc.Click += new System.EventHandler(this.btnNewAcc_Click);
            // 
            // dgvAccs
            // 
            this.dgvAccs.AllowUserToAddRows = false;
            this.dgvAccs.AllowUserToDeleteRows = false;
            this.dgvAccs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Currency,
            this.Balance,
            this.Details});
            this.dgvAccs.Location = new System.Drawing.Point(5, 18);
            this.dgvAccs.Name = "dgvAccs";
            this.dgvAccs.ReadOnly = true;
            this.dgvAccs.RowTemplate.Height = 25;
            this.dgvAccs.Size = new System.Drawing.Size(464, 214);
            this.dgvAccs.TabIndex = 0;
            this.dgvAccs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccs_CellContentClick);
            // 
            // Type
            // 
            this.Type.DataPropertyName = "AccountType";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 110;
            // 
            // Currency
            // 
            this.Currency.DataPropertyName = "Currency";
            this.Currency.HeaderText = "Currency";
            this.Currency.Name = "Currency";
            this.Currency.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "Balance";
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.Width = 110;
            // 
            // Details
            // 
            this.Details.HeaderText = "Details";
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Text = "Open";
            this.Details.UseColumnTextForButtonValue = true;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(28, 19);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(39, 13);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "Client: ";
            // 
            // lblClientJMBG
            // 
            this.lblClientJMBG.AutoSize = true;
            this.lblClientJMBG.Location = new System.Drawing.Point(28, 36);
            this.lblClientJMBG.Name = "lblClientJMBG";
            this.lblClientJMBG.Size = new System.Drawing.Size(42, 13);
            this.lblClientJMBG.TabIndex = 2;
            this.lblClientJMBG.Text = "JMBG: ";
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 357);
            this.Controls.Add(this.lblClientJMBG);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAccounts";
            this.Text = "Client\'s accounts";
            this.Load += new System.EventHandler(this.frmAccounts_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAccs;
        private System.Windows.Forms.Button btnNewAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewButtonColumn Details;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblClientJMBG;
    }
}