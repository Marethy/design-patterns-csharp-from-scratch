// Base milk tea
using Decorator;

IMilkTea milkTea = new MilkTea("Basic Milk Tea", 10);

// Add pearl
milkTea = new PearlDecorator(milkTea);

// Add pudding
milkTea = new PuddingDecorator(milkTea);

// Add coconut
milkTea = new CoconutDecorator(milkTea);

// Print final decorated tea
Console.WriteLine(milkTea.ToDisplay());
// Output: Basic Milk Tea, pearl, pudding, coconut : 22