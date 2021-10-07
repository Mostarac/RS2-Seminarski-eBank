using System;
using System.Collections.Generic;
using System.Text;

namespace eBank.Model
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
