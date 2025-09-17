namespace Command;

// Command interface
public interface ICommand
{
    void Execute();
}

// Receiver: Chef
public class Chef(Ord)
{
    public void CookPizza() => Console.WriteLine("Chef: Cooking Pizza...");
    public void CookSteak() => Console.WriteLine("Chef: Cooking Steak...");
}

// Concrete Command: Pizza
public interface 
public class OrderPizza : ICommand
{
    private readonly Chef _chef;
    public OrderPizza(Chef chef) => _chef = chef;

    public void Execute() => _chef.CookPizza();
}

// Concrete Command: Steak
public class OrderSteak : ICommand
{
    private readonly Chef _chef;
    public OrderSteak(Chef chef) => _chef = chef;

    public void Execute() => _chef.CookSteak();
}

// Invoker: Waiter
public class Waiter
{
    private readonly List<ICommand> _orders = new();

    public void TakeOrder(ICommand order) => _orders.Add(order);

    public void PlaceOrders()
    {
        foreach (var order in _orders)
        {
            order.Execute();
        }
        _orders.Clear(); // clear sau khi đã gửi cho bếp
    }
}

// -------------------
// Client
// -------------------
class Program
{
    static void Main()
    {
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
    }
}
