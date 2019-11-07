using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class RateProvider : ICurrency
    {
        public double ExcangeDollarRate()
        {
            return 3.80;
        }

        public double ExcangeEuroRate()
        {
            return 4.0;
        }
    }
}
