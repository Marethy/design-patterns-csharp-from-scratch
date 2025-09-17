using Builder;

var builder = new HouseBuilder();

// Create a director
var director = new Director(builder);

// Build a simple house
House simpleHouse = director.ConstructSimpleHouse();
Console.WriteLine("Simple House:");
Console.WriteLine(simpleHouse);
Console.WriteLine();

// Build a luxury house
House luxuryHouse = director.ConstructLuxuryHouse();
Console.WriteLine("Luxury House:");
Console.WriteLine(luxuryHouse);
Console.WriteLine();

// Custom house using builder directly (method chaining)
House customHouse = builder
    .WithWalls(6)
    .WithWindows(8)
    .WithDoors(2)
    .AddRoof()
    .AddGarage()
    .AddSwimmingPool()
    .AddPlumbing()
    .AddHeatingSystem()
    .AddElectricalWiring()
    .Build();

Console.WriteLine("Custom House:");
Console.WriteLine(customHouse);