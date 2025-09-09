using AbstractFactory.Factory;
using AbstractFactory.Service;

IPaymentFactory factory = new PaypalFactory();
var orderService = new OrderService(factory);
orderService.Checkout("ORD123", 199.99m);

Console.WriteLine();

// Customer selects MoMo
factory = new MoMoFactory();
orderService = new OrderService(factory);
orderService.Checkout("ORD124", 350.50m);