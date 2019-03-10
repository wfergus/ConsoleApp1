using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyProject
{
    public interface ICoin : ICurrency
    {
        short Year { get; }
    }
}
