using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyProject
{
    public abstract class USCoin : Coin
    {
        public USCoinMintMark MintMark;
        public string mmName;

        public USCoin()
        {

        }
        public USCoin(USCoinMintMark mm)
        {
            MintMark = mm;
        }

        public string About()
        {
            return $" ";
        }

        public void GetMintNameFromMark(USCoinMintMark mm)
        {
            switch (mm)
            {
                case USCoinMintMark.P: mmName = "Philadelphia"; break;
                case USCoinMintMark.D: mmName = "Denver"; break;
                case USCoinMintMark.S: mmName = "San Francisco"; break;
                case USCoinMintMark.W: mmName = "West Point"; break;
            }
        }
    }
}
