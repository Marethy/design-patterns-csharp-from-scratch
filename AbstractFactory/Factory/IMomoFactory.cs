using AbstractFactory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class MoMoFactory : IPaymentFactory
    {
        public IPaymentProcessor CreatePaymentProcessor() => new MoMoPaymentProcessor();
        public IInvoiceGenerator CreateInvoiceGenerator() => new MoMoInvoiceGenerator();
    }
}
