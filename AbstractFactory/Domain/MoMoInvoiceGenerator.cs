using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Domain
{
    public class MoMoInvoiceGenerator : IInvoiceGenerator
    {
        public void GenerateInvoice(string orderId, decimal amount)
        {
            Console.WriteLine($"[MoMo] Invoice generated for Order {orderId}, Amount: ${amount}");
        }
    }
}
