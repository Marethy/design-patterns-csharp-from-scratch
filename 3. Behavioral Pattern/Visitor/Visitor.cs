namespace Visitor;
public interface IVisitor
{
    void Visit(Book book);
    void Visit(Electronics electronics);
    void Visit(Clothing clothing);
}
public interface IElement
{
    void Accept(IVisitor visitor);
}
public class Book(string title, decimal price) : IElement
{
    public string Title { get; } = title;
    public decimal Price { get; } = price;

    public void Accept(IVisitor visitor) => visitor.Visit(this);
}
public class Electronics(string name, decimal price) : IElement
{
    public string Name { get; } = name;
    public decimal Price { get; } = price;
    public void Accept(IVisitor visitor) => visitor.Visit(this);
}
public class Clothing(string brand, decimal price) : IElement
{
    public string Brand { get; } = brand;
    public decimal Price { get; } = price;
    public void Accept(IVisitor visitor) => visitor.Visit(this);
}
//Concrete Visitor
public class TaxVisitor(decimal taxRate) : IVisitor
{
    public decimal TotalTax { get; private set; } = 0;
    public void Visit(Book book)
    {
        var tax = book.Price * taxRate * 0.5m; 
        TotalTax += tax;
        Console.WriteLine($"Book: {book.Title}, Price: {book.Price}, Tax: {tax}");
    }
    public void Visit(Electronics electronics)
    {
        var tax = electronics.Price * taxRate;
        TotalTax += tax;
        Console.WriteLine($"Electronics: {electronics.Name}, Price: {electronics.Price}, Tax: {tax}");
    }
    public void Visit (Clothing clothing)
    {
        var tax = clothing.Price * taxRate * 0.8m; 
        TotalTax += tax;
        Console.WriteLine($"Clothing: {clothing.Brand}, Price: {clothing.Price}, Tax: {tax}");
    }
}
public class DiscountVisitor(decimal discountRate) : IVisitor
{
    public decimal TotalDiscount { get; private set; } = 0;
    public void Visit(Book book)
    {
        var discount = book.Price * discountRate * 0.1m; 
        TotalDiscount += discount;
        Console.WriteLine($"Book: {book.Title}, Price: {book.Price}, Discount: {discount}");
    }
    public void Visit(Electronics electronics)
    {
        var discount = electronics.Price * discountRate * 0.2m; 
        TotalDiscount += discount;
        Console.WriteLine($"Electronics: {electronics.Name}, Price: {electronics.Price}, Discount: {discount}");
    }
    public void Visit(Clothing clothing)
    {
        var discount = clothing.Price * discountRate * 0.15m; 
        TotalDiscount += discount;
        Console.WriteLine($"Clothing: {clothing.Brand}, Price: {clothing.Price}, Discount: {discount}");
    }
}