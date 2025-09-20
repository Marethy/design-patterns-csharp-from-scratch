using Strategy;

var service = new PaymentService();

service.SetPaymentMethod(new PayPalPayment("123"));
service.Checkout(100);

service.SetPaymentMethod(new CreditCardPayment("j=holder"));
service.Checkout(200);

//service.SetPaymentMethod(new BankTransferPayment("transfer"));
//service.Checkout(300);