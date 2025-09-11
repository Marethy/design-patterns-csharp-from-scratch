using DecoratorPattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public class SugarDecorator(ICoffee coffee) : CoffeeDecorator(coffee)
    {
        public override string GetDescription() => coffee.GetDescription() + ", Sugar";
        public override decimal GetCost() => coffee.GetCost() + 0.50m;
    }
}
