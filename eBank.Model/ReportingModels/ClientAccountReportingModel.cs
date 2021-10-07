using System;
using System.Collections.Generic;
using System.Text;

namespace eBank.Model.ReportingModels
{
    public class ClientAccountReportingModel
    {
        public string AccountNumber { get; set; }
        public string MonthlyIncoming { get; set; }
        public string MonthlyOutgoing { get; set; }
        public string MonthlyTotal { get; set; }
    }
}
