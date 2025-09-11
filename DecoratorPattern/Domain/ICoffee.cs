using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Domain
{
    public interface ICoffee
    {
        string GetDescription();
        decimal GetCost();
    }
}
