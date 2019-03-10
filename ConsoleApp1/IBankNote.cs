using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IBankNote : ICurrency
    {
        short Year { get; }
    }
}
