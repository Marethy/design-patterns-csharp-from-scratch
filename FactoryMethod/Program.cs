using FactoryMethod.Domain;
using FactoryMethod.Factory;

Console.WriteLine("Select Payment Method: 1 = CreditCard, 2 = PayPal, 3 = BankTransfer");
string choice = Console.ReadLine();

PaymentFactory factory;

switch (choice)
{ 
    case "1":
        factory = new CreditCardPaymentFactory();
        break;
    case "2":
        factory = new PayPalPaymentFactory();
        break;
    case "3":
        factory = new BankTransferPaymentFactory();
        break;
    default:
        throw new Exception("Invalid payment method");
}

// Use Factory Method
IPayment payment = factory.CreatePayment();
payment.ProcessPayment(250.00m); // Pay $250