using Bridge;

var payment = new PaymentService();
payment.SetPaymentMethod(new PayPalPayment());
payment.Checkout(150);

// 
payment.SetPaymentMethod(new CreditCardPayment());
payment.Checkout(250);
