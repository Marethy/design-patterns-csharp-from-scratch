using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    // Implementor
    public interface IPaymentMethod
    {
        void Pay(decimal amount);
    }
    // Concrete Implementor 1
    public class PayPalPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using PayPal.");
        }
    }
    // Concrete Implementor 2
    public class CreditCardPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card.");
        }
    }

    // Abstraction
    public class PaymentService
    {
        private IPaymentMethod _paymentMethod;
        public void SetPaymentMethod(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }
        public void Checkout(decimal amount)
        {
            if (_paymentMethod == null)
            {
                throw new InvalidOperationException("Payment method not set.");
            }
            _paymentMethod.Pay(amount);
        }
    }

    // Refined Abstraction
    public class AdvancedPaymentService : PaymentService
    {
        public void ApplyDiscount(decimal amount, decimal discount)
        {
            var discountedAmount = amount - discount;
            Console.WriteLine($"Applying discount of {discount}. New amount: {discountedAmount}");
            Checkout(discountedAmount);
        }
    }
}
