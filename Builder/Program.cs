using Builder.Builder;
using Builder;

IOrderBuilder builder =  new OrderBuilder(new Order());

builder.SetPaymentMethod("Cash on Delivery")
       .SetCustomer("Nguyen Van A")
       .SetShippingAddress("456 Nguyen Trai, HCMC")
       .AddItem("Phone", 800.00m)
       .AddItem("Headphones", 150.00m);

Order order = builder
    .SetCustomer("Tran Khiem")
    .SetShippingAddress("123 Le Loi, HCMC")
    .SetPaymentMethod("Credit Card")
    .AddItem("Laptop", 1200.00m)
    .AddItem("Mouse", 25.50m)
    .Build();

Console.WriteLine(order);