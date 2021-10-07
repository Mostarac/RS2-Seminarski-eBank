
namespace eBank.WinUI.Accounts
{
    partial class frmAccountTransactions
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
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblJMBG = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTransactions);
            this.groupBox1.Location = new System.Drawing.Point(10, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transactions";
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeColumn,
            this.AmountColumn,
            this.ParticipantColumn,
            this.DescriptionColumn,
            this.DateColumn});
            this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransactions.Location = new System.Drawing.Point(3, 16);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowTemplate.Height = 25;
            this.dgvTransactions.Size = new System.Drawing.Size(694, 258);
            this.dgvTransactions.TabIndex = 0;
            // 
            // TypeColumn
            // 
            this.TypeColumn.DataPropertyName = "Type";
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            // 
            // AmountColumn
            // 
            this.AmountColumn.DataPropertyName = "Amount";
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            // 
            // ParticipantColumn
            // 
            this.ParticipantColumn.DataPropertyName = "Participant";
            this.ParticipantColumn.HeaderText = "From / to";
            this.ParticipantColumn.Name = "ParticipantColumn";
            this.ParticipantColumn.ReadOnly = true;
            this.ParticipantColumn.Width = 150;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.DataPropertyName = "Description";
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.ReadOnly = true;
            this.DescriptionColumn.Width = 200;
            // 
            // DateColumn
            // 
            this.DateColumn.DataPropertyName = "Date";
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(26, 24);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(39, 13);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "Client: ";
            // 
            // lblJMBG
            // 
            this.lblJMBG.AutoSize = true;
            this.lblJMBG.Location = new System.Drawing.Point(26, 48);
            this.lblJMBG.Name = "lblJMBG";
            this.lblJMBG.Size = new System.Drawing.Size(42, 13);
            this.lblJMBG.TabIndex = 2;
            this.lblJMBG.Text = "JMBG: ";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(26, 70);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(53, 13);
            this.lblAccount.TabIndex = 3;
            this.lblAccount.Text = "Account: ";
            // 
            // frmAccountTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 390);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblJMBG);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAccountTransactions";
            this.Text = "Account transactions";
            this.Load += new System.EventHandler(this.frmAccountTransactions_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblJMBG;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
    }
}