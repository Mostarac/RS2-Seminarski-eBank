using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBank.Model.Requests
{
    public class TransactionInsertRequest
    {
        [Required]
        public string RecipientNumber { get; set; }
        [Required]
        public string SenderNumber { get; set; }
        public double? Amount { get; set; }
        public double? CounterAmount { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
