using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyProject
{
    public class Nickel : USCoin
    {
        public Nickel()
        {
            MonetaryValue = 0.05d;
            Name = "Nickel";
        }
        public Nickel(USCoinMintMark mm)
        {
            MonetaryValue = 0.05d;
            Name = "Nickel";
            MintMark = mm;
        }
    }
}
