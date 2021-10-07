using System;
using System.Collections.Generic;
using System.Text;

namespace eBank.Model.Requests
{
    public class TransactionSearchRequest
    {
        public int? AccountId { get; set; }
        public int? LoanOrderId { get; set; }
    }
}
