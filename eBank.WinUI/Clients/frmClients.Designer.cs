
namespace eBank.WinUI.Clients
{
    partial class frmClients
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
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.groupBoxClients = new System.Windows.Forms.GroupBox();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.columnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnJMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Location = new System.Drawing.Point(83, 57);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(259, 20);
            this.txtSearchClient.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(425, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNewClient
            // 
            this.btnNewClient.Location = new System.Drawing.Point(425, 337);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(86, 23);
            this.btnNewClient.TabIndex = 2;
            this.btnNewClient.Text = "New client";
            this.btnNewClient.UseVisualStyleBackColor = true;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // groupBoxClients
            // 
            this.groupBoxClients.Controls.Add(this.dgvClients);
            this.groupBoxClients.Location = new System.Drawing.Point(27, 110);
            this.groupBoxClients.Name = "groupBoxClients";
            this.groupBoxClients.Size = new System.Drawing.Size(569, 192);
            this.groupBoxClients.TabIndex = 3;
            this.groupBoxClients.TabStop = false;
            this.groupBoxClients.Text = "Clients";
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFirstName,
            this.columnLastName,
            this.columnJMBG,
            this.columnDetails});
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClients.Location = new System.Drawing.Point(3, 16);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowTemplate.Height = 25;
            this.dgvClients.Size = new System.Drawing.Size(563, 173);
            this.dgvClients.TabIndex = 0;
            this.dgvClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellContentClick);
            // 
            // columnFirstName
            // 
            this.columnFirstName.DataPropertyName = "FirstName";
            this.columnFirstName.HeaderText = "First name";
            this.columnFirstName.Name = "columnFirstName";
            this.columnFirstName.ReadOnly = true;
            this.columnFirstName.Width = 120;
            // 
            // columnLastName
            // 
            this.columnLastName.DataPropertyName = "LastName";
            this.columnLastName.HeaderText = "Last name";
            this.columnLastName.Name = "columnLastName";
            this.columnLastName.ReadOnly = true;
            this.columnLastName.Width = 120;
            // 
            // columnJMBG
            // 
            this.columnJMBG.DataPropertyName = "JMBG";
            this.columnJMBG.HeaderText = "JMBG";
            this.columnJMBG.Name = "columnJMBG";
            this.columnJMBG.ReadOnly = true;
            this.columnJMBG.Width = 140;
            // 
            // columnDetails
            // 
            this.columnDetails.HeaderText = "Details";
            this.columnDetails.Name = "columnDetails";
            this.columnDetails.ReadOnly = true;
            this.columnDetails.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnDetails.Text = "Open";
            this.columnDetails.UseColumnTextForButtonValue = true;
            this.columnDetails.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search clients by name / JMBG:";
            // 
            // frmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxClients);
            this.Controls.Add(this.btnNewClient);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchClient);
            this.Name = "frmClients";
            this.Text = "Clients";
            this.groupBoxClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchClient;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxClients;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnJMBG;
        private System.Windows.Forms.DataGridViewButtonColumn columnDetails;
    }
}