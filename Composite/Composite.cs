namespace Composite;

public interface ICartItem
{
    string Name { get; }
    decimal GetPrice();
}

// Leaf
public record class Product(string Name, decimal Price) : ICartItem
{
    public decimal GetPrice() => Price;
    public override string ToString() => $"{Name} - {Price:C}";
}

// Composite
public class ProductBundle(string name, IReadOnlyList<ICartItem> items, decimal discount = 0m) : ICartItem
{
    public string Name { get; } = name;
    public IReadOnlyList<ICartItem> Items { get; } = items ?? throw new ArgumentNullException(nameof(items));
    public decimal Discount { get; } = discount;

    public decimal GetPrice() => Items.Sum(item => item.GetPrice()) - Discount;

    public override string ToString()
        => $"{Name} Bundle: {Items.Count} items, Total = {GetPrice():C}";
}
