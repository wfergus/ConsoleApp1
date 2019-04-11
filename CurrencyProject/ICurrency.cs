using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyProject
{
    public interface ICurrency
    {
        string Name { get; }
        double MonetaryValue { get; set; }
   
        string About();
    }
}
