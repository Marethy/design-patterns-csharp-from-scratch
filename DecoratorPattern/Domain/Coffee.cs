using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Domain
{
    public class Coffee : ICoffee
    {
        public string GetDescription() => "Coffee";
        public decimal GetCost() => 2.00m;
    }
}
