using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyProject
{
    public class CurrencyRepo : ICurrencyRepo
    {
        public List<ICoin> Coins { get; set; }

        public CurrencyRepo() { }

        public string About()
        {

        }
        public void AddCoin(ICoin C)
        {

        }
        public ICurrencyRepo CreateChange(double Amount)
        {

        }
        public ICurrencyRepo CreateChange(double AmountTendered, double TotalCost)
        {

        }
        public int GetCoinCount()
        {

        }
        public ICurrencyRepo MakeChange(double Amount)
        {

        }
        public ICurrencyRepo MakeChange(double AmountTendered, double TotalCost)
        {

        }
        public ICoin RemoveCoin(ICoin c)
        {

        }
        public double TotalValue()
        {

        }
    }
}
