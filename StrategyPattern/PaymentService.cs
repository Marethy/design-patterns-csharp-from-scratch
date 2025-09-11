using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class PaymentService
    {
        private IPaymentStrategy _paymentStrategy;

        public void SetPaymentMethod(IPaymentStrategy strategy)
        {
            _paymentStrategy = strategy;
        }

        public void Checkout(decimal amount)
        {
            if (_paymentStrategy == null)
            {
                Console.WriteLine("No payment method selected!");
                return;
            }
            _paymentStrategy.Pay(amount);
        }
    }


}
