namespace Strategy;

public interface IPayment
{
    void Checkout(decimal amount);
}

public class CreditCardPayment(string cardHolder) : IPayment
{
    public string CardHolder { get; } = cardHolder;

    public void Checkout(decimal amount)
        => Console.WriteLine($"Paid {amount} using credit card of {CardHolder}");
}

public class PayPalPayment(string email) : IPayment
{
    public string Email { get; } = email;

    public void Checkout(decimal amount)
        => Console.WriteLine($"Paid {amount} via PayPal account {Email}");
}

public class PaymentService()
{
    private IPayment _payment =new  CreditCardPayment("Default User"); // Default strategy

    public void SetPaymentMethod(IPayment payment) => _payment = payment;

    public void Checkout(decimal amount) => _payment.Checkout(amount);
}
