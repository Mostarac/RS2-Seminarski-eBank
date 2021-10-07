using System;
using System.Collections.Generic;
using System.Text;

namespace eBank.Model.Requests
{
    public class LoanOrderSearchRequest
    {
        public int? UserId { get; set; }
        public LoanOrderState? LoanOrderState { get; set; }
        public string JMBG { get; set; }
        public string LoanName { get; set; }

        public int? LoanId { get; set; }
    }
}
