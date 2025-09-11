using DecoratorPattern.Decorator;
using DecoratorPattern.Domain;

ICoffee coffee = new Coffee();
Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetCost()}");

// Add Milk
coffee = new MilkDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetCost()}");


// Add Sugar + Milk
ICoffee coffeeWithMilkAndSugar = new SugarDecorator(new MilkDecorator(new Coffee()));
Console.WriteLine($"{coffeeWithMilkAndSugar.GetDescription()} - ${coffeeWithMilkAndSugar.GetCost()}");
