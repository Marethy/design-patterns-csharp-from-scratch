// Create original object
using Prototype;

var original = new Laptop("Dell", "XPS 15", 16, 512);

// List to hold clones
var laptops = new List<Laptop>();

// Create 100 clones
for (int i = 1; i <= 100; i++)
{
    var clone = original.Clone();
    clone.Model = $"XPS {15 + i}";   // customize each clone a bit
    clone.RAM = 8 + i;               // vary RAM for demo
    laptops.Add(clone);
}

// Print first 5 to check
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(laptops[i]);
}

Console.WriteLine($"\nTotal laptops created: {laptops.Count}");
        