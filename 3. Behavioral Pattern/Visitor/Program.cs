using Visitor;

var products = new List<IElement>
{
    new Book("C# in Depth", 50),
    new Electronics("Laptop", 1000),
    new Clothing("Nike T-Shirt", 30)
};

var taxVisitor = new TaxVisitor(0.1m); // 10%
foreach (var product in products)
    product.Accept(taxVisitor);

Console.WriteLine($"Total Tax: {taxVisitor.TotalTax}");
