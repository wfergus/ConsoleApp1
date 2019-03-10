using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyProject
{
    public abstract class USCoin : Coin
    {
        USCoinMintMark MintMark;

        public USCoin() { }
        public USCoin(USCoinMintMark mm) { }

        public string About()
        {

        }

        public void GetMintNameFromMark()
        {

        }

    }
}
