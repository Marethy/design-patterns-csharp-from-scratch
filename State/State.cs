using System;
using System.Collections.Generic;

namespace State
{
    public enum OrderStatus
    {
        Pending,
        Shipped,
        Delivered,
        Cancelled
    }

    public interface IOrderState
    {
        OrderStatus Status { get; }
        void Ship(Order order);
        void Deliver(Order order);
        void Cancel(Order order);
    }

    public sealed class PendingState : IOrderState
    {
        public static readonly PendingState Instance = new PendingState();
        private PendingState() { }
        public OrderStatus Status => OrderStatus.Pending;

        public void Ship(Order order)
        {
            order.TransitionTo(ShippedState.Instance);
            Console.WriteLine("Order shipped!");
        }

        public void Deliver(Order order)
        {
            Console.WriteLine("Cannot deliver order in current state!");
        }

        public void Cancel(Order order)
        {
            order.TransitionTo(CancelledState.Instance);
            Console.WriteLine("Order cancelled!");
        }
    }

    public sealed class ShippedState : IOrderState
    {
        public static readonly ShippedState Instance = new ShippedState();
        private ShippedState() { }
        public OrderStatus Status => OrderStatus.Shipped;

        public void Ship(Order order)
        {
            Console.WriteLine("Cannot ship order in current state!");
        }

        public void Deliver(Order order)
        {
            order.TransitionTo(DeliveredState.Instance);
            Console.WriteLine("Order delivered!");
        }

        public void Cancel(Order order)
        {
            // business rule: không thể cancel sau khi shipped (thay đổi theo nghiệp vụ)
            Console.WriteLine("Cannot cancel order in current state!");
        }
    }

    public sealed class DeliveredState : IOrderState
    {
        public static readonly DeliveredState Instance = new DeliveredState();
        private DeliveredState() { }
        public OrderStatus Status => OrderStatus.Delivered;

        public void Ship(Order order)
        {
            Console.WriteLine("Cannot ship order in current state!");
        }

        public void Deliver(Order order)
        {
            Console.WriteLine("Cannot deliver order in current state!");
        }

        public void Cancel(Order order)
        {
            Console.WriteLine("Cannot cancel order in current state!");
        }
    }

    public sealed class CancelledState : IOrderState
    {
        public static readonly CancelledState Instance = new CancelledState();
        private CancelledState() { }
        public OrderStatus Status => OrderStatus.Cancelled;

        public void Ship(Order order)
        {
            Console.WriteLine("Cannot ship order. It's cancelled.");
        }

        public void Deliver(Order order)
        {
            Console.WriteLine("Cannot deliver order. It's cancelled.");
        }

        public void Cancel(Order order)
        {
            Console.WriteLine("Order is already cancelled.");
        }
    }

    // 4. Context: Order
    public class Order
    {
        // read-only id
        public Guid Id { get; } = Guid.NewGuid();

        // Current state (encapsulated)
        private IOrderState _state;
        public IOrderState State => _state; // expose read-only if needed

        // Expose a persisted-friendly status
        public OrderStatus Status => _state.Status;

        // history for audit
        private readonly List<(OrderStatus Status, DateTime Time)> _history = new();
        public IReadOnlyList<(OrderStatus Status, DateTime Time)> History => _history.AsReadOnly();

        public Order()
        {
            // khởi tạo state mặc định
            _state = PendingState.Instance;
            _history.Add((_state.Status, DateTime.UtcNow));
        }

        // internal transition method: mọi thay đổi state đều qua đây
        internal void TransitionTo(IOrderState newState)
        {
            if (newState == null) throw new ArgumentNullException(nameof(newState));
            if (ReferenceEquals(_state, newState)) return; // no-op nếu cùng state

            _state = newState;
            _history.Add((_state.Status, DateTime.UtcNow));
            // TODO: có thể trigger events / logging / persistence ở đây
        }

        // Action methods delegate cho state hiện tại
        public void Ship() => _state.Ship(this);
        public void Deliver() => _state.Deliver(this);
        public void Cancel() => _state.Cancel(this);
    }

    // 5. Demo
    internal class Program
    {
        private static void Main()
        {
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
        }
    }
}
