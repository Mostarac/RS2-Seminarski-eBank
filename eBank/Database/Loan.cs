using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Database
{
    public class Loan
    {
        public int LoanId { get; set; }

        public string Name { get; set; }

        public int MinPayments { get; set; }

        public int MaxPayments { get; set; }

        //EIR: effective interest rate
        public double EIR { get; set; }

        public double Limit { get; set; }

        [ForeignKey(nameof(Account))]
        public int LenderId { get; set; }

        public Account Lender { get; set; }
    }
}
