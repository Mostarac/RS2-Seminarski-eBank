using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Database
{
    public class CurrencyPair
    {
        public int CurrencyPairId { get; set; }
        public string FirstId { get; set; }
        public Currency First { get; set; }
        public string SecondId { get; set; }
        public Currency Second { get; set; }
        public double RatioFirstSecond { get; set; }
    }
}
