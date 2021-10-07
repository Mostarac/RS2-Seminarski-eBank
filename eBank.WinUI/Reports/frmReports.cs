using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBank.WinUI.Reports
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            ReportParameterCollection rpc = new ReportParameterCollection();

            rpc.Add(new ReportParameter("FromAmount", "1000"));
            rpc.Add(new ReportParameter("ToAmount", "1000"));

            reportViewer1.LocalReport.SetParameters(rpc);

            this.reportViewer1.RefreshReport();
        }
    }
}
