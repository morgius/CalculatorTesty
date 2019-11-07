using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class CurrencyCalculator
    {
        private ICurrency provider;
        public CurrencyCalculator(ICurrency provider)
        {
            this.provider = provider;
        }
        public double EuroToZloty(double value)
        {
            return provider.ExcangeEuroRate() * value;
        }
        public double DolarToZloty(double value)
        {
            return provider.ExcangeDollarRate() * value;
        }
    }
}
