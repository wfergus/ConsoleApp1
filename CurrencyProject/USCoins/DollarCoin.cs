using CurrencyProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyProject
{
    public class DollarCoin : USCoin
    {
        public DollarCoin()
        {
            MonetaryValue = 1.00d;
            Name = "Dollar Coin";
        }
        public DollarCoin(USCoinMintMark mm)
        {
            MonetaryValue = 1.00d;
            Name = "Dollar Coin";
            MintMark = mm;
        }
    }
}
