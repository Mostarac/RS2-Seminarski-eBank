
namespace eBank.WinUI.Reports
{
    partial class frmLoanReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.nudFrom = new System.Windows.Forms.NumericUpDown();
            this.nudTo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTo)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eBank.WinUI.Reports.rptLoans.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 72);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(900, 322);
            this.reportViewer1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Show all active client loans, with total amount from ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "to";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(679, 31);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(93, 23);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // nudFrom
            // 
            this.nudFrom.DecimalPlaces = 2;
            this.nudFrom.Location = new System.Drawing.Point(358, 34);
            this.nudFrom.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudFrom.Name = "nudFrom";
            this.nudFrom.Size = new System.Drawing.Size(120, 20);
            this.nudFrom.TabIndex = 9;
            // 
            // nudTo
            // 
            this.nudTo.DecimalPlaces = 2;
            this.nudTo.Location = new System.Drawing.Point(510, 34);
            this.nudTo.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudTo.Name = "nudTo";
            this.nudTo.Size = new System.Drawing.Size(120, 20);
            this.nudTo.TabIndex = 10;
            // 
            // frmLoanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 406);
            this.Controls.Add(this.nudTo);
            this.Controls.Add(this.nudFrom);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmLoanReport";
            this.Text = "Loan overview report";
            this.Load += new System.EventHandler(this.frmLoanReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.NumericUpDown nudFrom;
        private System.Windows.Forms.NumericUpDown nudTo;
    }
}