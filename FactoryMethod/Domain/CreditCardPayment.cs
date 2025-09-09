using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Domain
{
    public class CreditCardPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Credit Card payment of {amount:C}");
        }
    }
}
