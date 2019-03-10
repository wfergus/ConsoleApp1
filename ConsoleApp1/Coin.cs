using System;
using System.Collections.Generic;
using System.Text;


namespace CurrencyProject
{
    public abstract class Coin : ICoin
    {
        public double MonetaryValue { get; set; }
        public string Name { get; set; }
        public short Year { get; set; }

        public Coin()
        {
            
        }
        public string About()
        {

        }
    }
}
