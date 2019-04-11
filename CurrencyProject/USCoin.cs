using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyProject
{
    public abstract class USCoin : Coin
    {
        public USCoinMintMark MintMark;
        
        public USCoin() { }
        public USCoin(USCoinMintMark mm)
        {
            MintMark = mm;
        }

        public string About()
        {
            return $" ";
        }

        public void GetMintNameFromMark()
        {
            
        }

    }
}
