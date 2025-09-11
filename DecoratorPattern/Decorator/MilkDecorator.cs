using DecoratorPattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    internal class MilkDecorator(ICoffee coffee) : CoffeeDecorator(coffee)
    {
        public override string GetDescription() => coffee.GetDescription() + ", Milk";
        public override decimal GetCost() => coffee.GetCost() + 5.00m;
    }

}
