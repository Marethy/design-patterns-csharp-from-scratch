using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    public interface IOrderBuilder
    {
        IOrderBuilder SetCustomer(string name);
        IOrderBuilder SetShippingAddress(string address);
        IOrderBuilder SetPaymentMethod(string method);
        IOrderBuilder AddItem(string item, decimal price);
        Order Build();
    }

}
