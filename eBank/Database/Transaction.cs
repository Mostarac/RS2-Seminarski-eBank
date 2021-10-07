using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Database
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int RecipientId { get; set; }
        public AccountNumber Recipient { get; set; }
        public int SenderId { get; set; }
        public AccountNumber Sender { get; set; }
        public double Amount { get; set; }
        public double CounterAmount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
