using AbstractFactory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class PaypalFactory : IPaymentFactory
    {
        public IPaymentProcessor CreatePaymentProcessor() => new PaypalPaymentProcessor();
        public IInvoiceGenerator CreateInvoiceGenerator() => new PaypalInvoiceGenerator();
    }
}
