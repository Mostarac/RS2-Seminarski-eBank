
namespace eBank.WinUI.LoanOrders
{
    partial class frmLoanOrders
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
            this.txtSearchLoanOrder = new System.Windows.Forms.TextBox();
            this.btnSearchLO = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLoanOrders = new System.Windows.Forms.DataGridView();
            this.ClientFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanOrderDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchLoanOrder
            // 
            this.txtSearchLoanOrder.Location = new System.Drawing.Point(81, 70);
            this.txtSearchLoanOrder.Name = "txtSearchLoanOrder";
            this.txtSearchLoanOrder.Size = new System.Drawing.Size(251, 20);
            this.txtSearchLoanOrder.TabIndex = 0;
            // 
            // btnSearchLO
            // 
            this.btnSearchLO.Location = new System.Drawing.Point(420, 70);
            this.btnSearchLO.Name = "btnSearchLO";
            this.btnSearchLO.Size = new System.Drawing.Size(64, 19);
            this.btnSearchLO.TabIndex = 1;
            this.btnSearchLO.Text = "Search";
            this.btnSearchLO.UseVisualStyleBackColor = true;
            this.btnSearchLO.Click += new System.EventHandler(this.btnSearchLO_ClickAsync);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLoanOrders);
            this.groupBox1.Location = new System.Drawing.Point(10, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 213);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan orders";
            // 
            // dgvLoanOrders
            // 
            this.dgvLoanOrders.AllowUserToAddRows = false;
            this.dgvLoanOrders.AllowUserToDeleteRows = false;
            this.dgvLoanOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientFullName,
            this.JMBG,
            this.LoanModel,
            this.State,
            this.LoanOrderDetails});
            this.dgvLoanOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoanOrders.Location = new System.Drawing.Point(3, 16);
            this.dgvLoanOrders.Name = "dgvLoanOrders";
            this.dgvLoanOrders.ReadOnly = true;
            this.dgvLoanOrders.RowTemplate.Height = 25;
            this.dgvLoanOrders.Size = new System.Drawing.Size(593, 194);
            this.dgvLoanOrders.TabIndex = 0;
            this.dgvLoanOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoanOrders_CellContentClick);
            // 
            // ClientFullName
            // 
            this.ClientFullName.DataPropertyName = "ClientFullName";
            this.ClientFullName.HeaderText = "Client";
            this.ClientFullName.Name = "ClientFullName";
            this.ClientFullName.ReadOnly = true;
            // 
            // JMBG
            // 
            this.JMBG.DataPropertyName = "JMBG";
            this.JMBG.HeaderText = "JMBG";
            this.JMBG.Name = "JMBG";
            this.JMBG.ReadOnly = true;
            this.JMBG.Width = 130;
            // 
            // LoanModel
            // 
            this.LoanModel.DataPropertyName = "LoanModel";
            this.LoanModel.HeaderText = "Loan model";
            this.LoanModel.Name = "LoanModel";
            this.LoanModel.ReadOnly = true;
            this.LoanModel.Width = 120;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // LoanOrderDetails
            // 
            this.LoanOrderDetails.HeaderText = "Details";
            this.LoanOrderDetails.Name = "LoanOrderDetails";
            this.LoanOrderDetails.ReadOnly = true;
            this.LoanOrderDetails.Text = "Open";
            this.LoanOrderDetails.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search loan orders by loan name / client JMBG:";
            // 
            // frmLoanOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearchLO);
            this.Controls.Add(this.txtSearchLoanOrder);
            this.Name = "frmLoanOrders";
            this.Text = "Loan orders";
            this.Load += new System.EventHandler(this.frmLoanOrders_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchLoanOrder;
        private System.Windows.Forms.Button btnSearchLO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLoanOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewButtonColumn LoanOrderDetails;
    }
}