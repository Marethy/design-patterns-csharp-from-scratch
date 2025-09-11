using Flyweight;

// Create a factory
var factory = new BookFactory();

// Request the same book twice
var b1 = factory.GetBook("Harry Potter", "J.K. Rowling", "12345");
var b2 = factory.GetBook("Harry Potter", "J.K. Rowling", "12345");

// Check if they reference the same object
Console.WriteLine(ReferenceEquals(b1, b2)); // True → same shared object

// Display them with different extrinsic states (inventory IDs)
b1.Display(101);
b2.Display(102);