using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using eBank.Model.Helpers.CustomDataAnnotations;

namespace eBank.Model.Requests
{
    public class LoanUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Range(1, 360)]
        [IsLessThanINT(nameof(MaxPayments))]
        public int MinPayments { get; set; }

        [Range(1, 360)]
        [IsGreaterThanINT(nameof(MinPayments))]
        public int MaxPayments { get; set; }

        //EIR: effective interest rate
        [Range(0, 100)]
        public double EIR { get; set; }
        [Range(0, double.MaxValue)]
        public double Limit { get; set; }
        [Required]
        public int LenderId { get; set; }

    }
}
