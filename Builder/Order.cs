using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Order
    {
        public string CustomerName { get; set; }
        public string ShippingAddress { get; set; }
        public string PaymentMethod { get; set; }
        public List<string> Items { get; set; } = [];
        public decimal Total { get; set; }

        public override string ToString()
        {
            return $"Order for {CustomerName}\n" +
                   $"Address: {ShippingAddress}\n" +
                   $"Payment: {PaymentMethod}\n" +
                   $"Items: {string.Join(", ", Items)}\n" +
                   $"Total: {Total:C}";
        }
    }
}
