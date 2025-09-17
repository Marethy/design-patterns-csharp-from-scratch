namespace Composite
{
    // The 'Component' interface
    // Both simple items and bundles will implement this
    public interface ICartItem
    {
        string Name { get; set; }
        decimal Price { get; }
    }

    // The 'Leaf' class (represents a single item)
    public class Item(string name, decimal unitPrice) : ICartItem
    {
        public string Name { get; set; } = name;
        public decimal Price { get; init; } = unitPrice;
    }

    // The 'Composite' class (represents a bundle of items)
    public class ItemBundle(string name, decimal discount = 0) : ICartItem
    {
        private readonly List<ICartItem> _items = [];
        public string Name { get; set; } = name;

        // Add items to the bundle
        public void AddItem(ICartItem item) => _items.Add(item);

        // Total price is the sum of all items minus discount
        public decimal Price => _items.Sum(i => i.Price) - discount;
    }
}
