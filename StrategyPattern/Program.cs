using StrategyPattern;

var service = new PaymentService();

service.SetPaymentMethod(new PayPalPayment());
service.Checkout(100);

service.SetPaymentMethod(new CreditCardPayment());
service.Checkout(200);

service.SetPaymentMethod(new BankTransferPayment());
service.Checkout(300);