using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    public class OrderBuilder(Order order) : IOrderBuilder
    {

        public IOrderBuilder SetCustomer(string name)
        {
            order.CustomerName = name;
            return this;
        }

        public IOrderBuilder SetShippingAddress(string address)
        {
            order.ShippingAddress = address;
            return this;
        }

        public IOrderBuilder SetPaymentMethod(string method)
        {
            order.PaymentMethod = method;
            return this;
        }

        public IOrderBuilder AddItem(string item, decimal price)
        {
            order.Items.Add(item);
            order.Total += price;
            return this;
        }

        public Order Build()
        {
            return order;
        }
    }
}
