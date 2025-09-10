using AdapterPattern;
using AdapterPattern.Adapter;
IPaymentProcessor processor = new PayPalAdapter(new PayPalService());

processor.Pay(150.75m);