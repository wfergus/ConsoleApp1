using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyProject
{
    public class Dime : USCoin
    {

        public Dime()
        {
            MonetaryValue = 0.10d;
            Name = "Dime";
        }
        public Dime(USCoinMintMark mm)
        {
            MonetaryValue = 0.10d;
            Name = "Dime";
            MintMark = mm;
        }
    }
}
