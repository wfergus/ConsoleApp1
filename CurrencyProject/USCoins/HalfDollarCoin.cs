using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyProject
{
    public class HalfDollarCoin : USCoin
    {
        public HalfDollarCoin()
        {
            MonetaryValue = 0.50d;
            Name = "Half Dollar Coin";
        }
        public HalfDollarCoin(USCoinMintMark mm)
        {
            MonetaryValue = 0.50d;
            Name = "Half Dollar Coin";
            MintMark = mm;
        }
    }
}
