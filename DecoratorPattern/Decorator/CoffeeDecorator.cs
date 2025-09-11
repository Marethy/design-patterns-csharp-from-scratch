using DecoratorPattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public abstract class CoffeeDecorator(ICoffee coffee) : ICoffee
    {
        public virtual decimal GetCost() => coffee.GetCost();
        public virtual string GetDescription() => coffee.GetDescription();
    }
    
}
