using System;
using System.Collections.Generic;
using System.Text;

namespace eBank.Model
{
    public class LoanEIRHistory
    {
        public int LoanEIRHistoryId { get; set; }

        public double EIR { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    }
}
