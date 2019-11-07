using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public interface ICurrency
    {
        double ExcangeDollarRate();
        double ExcangeEuroRate();
    }
}
