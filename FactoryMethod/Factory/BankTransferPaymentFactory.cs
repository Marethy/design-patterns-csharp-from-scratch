using FactoryMethod.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    public class BankTransferPaymentFactory : PaymentFactory
    {
        public override IPayment CreatePayment()
        {
            return new BankTransferPayment();
        }
    }
}
