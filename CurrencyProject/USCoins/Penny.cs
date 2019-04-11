using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyProject
{
    public class Penny : USCoin
    {
        public Penny()
        {
            MonetaryValue = 0.01d;
            Name = "Penny";
        }

        public Penny(USCoinMintMark mm)
        {
            MonetaryValue = 0.01d;
            Name = "Penny";
            MintMark = mm;
        }
    }
}
