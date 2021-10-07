using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Database
{
    public class LoanOrderTransaction
    {
        public int LoanOrderTransactionId { get; set; }

        public int LoanOrderId { get; set; }

        public LoanOrder LoanOrder { get; set; }

        public int TransactionId { get; set; }

        public Transaction Transaction { get; set; }

    }
}
