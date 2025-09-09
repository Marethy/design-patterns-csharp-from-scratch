using AbstractFactory.Domain;
using AbstractFactory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Service
{
    public class OrderService(IPaymentFactory factory)
    {
        private readonly IPaymentProcessor _paymentProcessor = factory.CreatePaymentProcessor();
        private readonly IInvoiceGenerator _invoiceGenerator = factory.CreateInvoiceGenerator();

        public void Checkout(string orderId, decimal amount)
        {
            Console.WriteLine($"[OrderService] Starting checkout for Order {orderId}");

            _paymentProcessor.ProcessPayment(amount);
            _invoiceGenerator.GenerateInvoice(orderId, amount);

            Console.WriteLine($"[OrderService] Checkout complete for Order {orderId}");
        }
    }
}
