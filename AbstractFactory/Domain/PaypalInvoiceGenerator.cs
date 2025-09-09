using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Domain
{
    public class PaypalInvoiceGenerator : IInvoiceGenerator
    {
        public void GenerateInvoice(string orderId, decimal amount)
        {
            Console.WriteLine($"[PayPal] Invoice generated for Order {orderId}, Amount: ${amount}");
        }
    }
}
