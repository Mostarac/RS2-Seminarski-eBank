using System;
using System.Collections.Generic;
using System.Text;

namespace eBank.Model.Requests
{
    public class AccountUpsertRequest
    {
        public int AccountTypeId { get; set; }
        public string CurrencyId { get; set; }
        public double Balance { get; set; }
        public double Limit { get; set; }
        public int UserId { get; set; }
    }
}
