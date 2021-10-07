using System;
using System.Collections.Generic;
using System.Text;

namespace eBank.Model.ReportingModels
{
    public class LoanOverviewReportingModel
    {
        public string LoanName { get; set; }
        public string ClientName { get; set; }
        public string Total { get; set; }
        public string NumberOfPayments { get; set; }
        public string RemainingPayments { get; set; }
        public string MonthlyPayment { get; set; }
        public string AverageMonthlyPayment { get; set; }
        public string AverageExtraPaid { get; set; }

    }
}
