using System;
using System.Collections.Generic;
using System.Text;

namespace eBank.Model.Requests
{
    public class LoanOrderTransactionUpsertRequest
    {

        public int LoanOrderId { get; set; }

        public int TransactionId { get; set; }

    }
}
