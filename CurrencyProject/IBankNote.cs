using CurrencyProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyProject
{
    public interface IBankNote : ICurrency
    {
        short Year { get; }
    }
}
