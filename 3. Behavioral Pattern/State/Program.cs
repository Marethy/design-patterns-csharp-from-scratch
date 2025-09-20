using State;

var order = new Order();
Console.WriteLine($"Initial status: {order.Status}");

order.Ship();    // Pending -> Shipped
Console.WriteLine($"After ship: {order.Status}");

order.Cancel();  // Cannot cancel after shipped
Console.WriteLine($"After cancel attempt: {order.Status}");

order.Deliver(); // Shipped -> Delivered
Console.WriteLine($"After deliver: {order.Status}");

// print history
Console.WriteLine("\nHistory:");
foreach (var (s, t) in order.History)
    Console.WriteLine($"{t:u} -> {s}");