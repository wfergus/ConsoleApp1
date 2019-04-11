using CurrencyProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyProject
{
    public class CurrencyRepo : ICurrencyRepo
    {
        public List<ICoin> Coins { get; set; }

        public CurrencyRepo()
        {
            Coins = new List<ICoin>();
        }

        public string About()
        {
            return $"This currency repo contains {Coins}.";
        }
        public void AddCoin(ICoin C)
        {
            Coins.Add(C);
        }
        public ICurrencyRepo CreateChange(double Amount)
        {
            CurrencyRepo changeRepo = new CurrencyRepo();
            while (Amount > 0)
            {
                if (Amount >= 1.00d)
                {
                    DollarCoin dc = new DollarCoin();
                    changeRepo.AddCoin(dc);
                    Amount = Amount - dc.MonetaryValue;
                }
                else if (Amount >= 0.50d)
                {
                    HalfDollarCoin hd = new HalfDollarCoin();
                    changeRepo.AddCoin(hd);
                    Amount = Amount - hd.MonetaryValue;
                }
                else if (Amount >= 0.25d)
                {
                    Quarter q = new Quarter();
                    changeRepo.AddCoin(q);
                    Amount = Amount - q.MonetaryValue;
                }
                else if (Amount >= 0.10d)
                {
                    Dime d = new Dime();
                    changeRepo.AddCoin(d);
                    Amount = Amount - d.MonetaryValue;
                }
                else if (Amount >= 0.05d)
                {
                    Nickel n = new Nickel();
                    changeRepo.AddCoin(n);
                    Amount = Amount - n.MonetaryValue;
                }
                else
                {
                    Penny p = new Penny();
                    changeRepo.AddCoin(p);
                    Amount = Amount - p.MonetaryValue;
                }
            }
            return changeRepo;
        }
        public ICurrencyRepo CreateChange(double AmountTendered, double TotalCost)
        {
            double change = AmountTendered - TotalCost;
            CurrencyRepo changeRepo = new CurrencyRepo();

            if (change > 0)
            {
                changeRepo.CreateChange(change);
            }
            return changeRepo;
        }
        public int GetCoinCount()
        {
            return Coins.Count;
        }
        public ICurrencyRepo MakeChange(double Amount)
        {

        }
        public ICurrencyRepo MakeChange(double AmountTendered, double TotalCost)
        {

        }
        public ICoin RemoveCoin(ICoin c)
        {
            Coins.Remove(c);
            return c;
        }
        public double TotalValue()
        {
            double total = 0.00d;

            foreach (Coin c in Coins)
            {
                total += c.MonetaryValue;
            }

            return total;
        }
    }
}
