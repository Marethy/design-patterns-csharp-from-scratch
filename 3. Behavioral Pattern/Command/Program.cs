// Tạo receiver
var chef = new Chef();

// Tạo command
var pizzaOrder = new OrderPizza(chef);
var steakOrder = new OrderSteak(chef);

// Waiter nhận order
var waiter = new Waiter();
waiter.TakeOrder(pizzaOrder);
waiter.TakeOrder(steakOrder);

// Gửi order cho bếp
waiter.PlaceOrders();

// Output:
// Chef: Cooking Pizza...
// Chef: Cooking Steak...
