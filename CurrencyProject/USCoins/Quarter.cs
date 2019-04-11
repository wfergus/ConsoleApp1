using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyProject
{
    public class Quarter : USCoin
    {
        public Quarter()
        {
            MonetaryValue = 0.25d;
            Name = "Quarter";
        }
        public Quarter(USCoinMintMark mm)
        {
            MonetaryValue = 0.25d;
            Name = "Quarter";
            MintMark = mm;
        }
    }
}
