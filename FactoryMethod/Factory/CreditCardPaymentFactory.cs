using FactoryMethod.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    public class CreditCardPaymentFactory : PaymentFactory
    {
        public override IPayment CreatePayment()
        {
            return new CreditCardPayment();
        }
    }
}
