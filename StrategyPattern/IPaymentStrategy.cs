using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(decimal amount) =>
            Console.WriteLine($"Paid {amount} with PayPal");
    }

    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount) =>
            Console.WriteLine($"Paid {amount} with Credit Card");
    }

    public class BankTransferPayment : IPaymentStrategy
    {
        public void Pay(decimal amount) =>
            Console.WriteLine($"Paid {amount} with Bank Transfer");
    }
}
