using System;
using System.Collections.Generic;
using System.Text;

namespace eBank.Model.Requests
{
    public class LoanOrderUpsertRequest
    {
        public int LoanId { get; set; }
        public int AccountId { get; set; }
        public double Amount { get; set; }
        public int Months { get; set; }
        public string Comment { get; set; }
        public LoanOrderState LoanOrderState { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
