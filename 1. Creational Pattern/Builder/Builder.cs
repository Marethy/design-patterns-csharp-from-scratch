namespace Builder;
// =========================
// 1. Product: House
// =========================
// House is a complex object with many optional and mandatory attributes.
// The constructor is private/internal to enforce creation via the Builder.
public class House
{
    // Read-only properties
    public int Walls { get; }
    public int Windows { get; }
    public int Doors { get; }
    public bool HasRoof { get; }
    public bool HasGarage { get; }
    public bool HasBackyard { get; }
    public bool HasSwimmingPool { get; }
    public bool HasPlumbing { get; }
    public bool HasHeatingSystem { get; }
    public bool HasElectricalWiring { get; }

    // Internal constructor: can only be called by the Builder
    internal House(
        int walls,
        int windows,
        int doors,
        bool hasRoof,
        bool hasGarage,
        bool hasBackyard,
        bool hasSwimmingPool,
        bool hasPlumbing,
        bool hasHeatingSystem,
        bool hasElectricalWiring)
    {

        Walls = walls;
        Windows = windows;
        Doors = doors;
        HasRoof = hasRoof;
        HasGarage = hasGarage;
        HasBackyard = hasBackyard;
        HasSwimmingPool = hasSwimmingPool;
        HasPlumbing = hasPlumbing;
        HasHeatingSystem = hasHeatingSystem;
        HasElectricalWiring = hasElectricalWiring;
    }

    // Override ToString() for easy display
    public override string ToString()
    {
        return $"House: {Walls} walls, {Windows} windows, {Doors} doors, " +
               $"Roof={HasRoof}, Garage={HasGarage}, Backyard={HasBackyard}, " +
               $"Pool={HasSwimmingPool}, Plumbing={HasPlumbing}, Heating={HasHeatingSystem}, Electrical={HasElectricalWiring}";
    }
}

// =========================
// 2. Builder Interface
// =========================
// Defines all possible steps to build a House
// Each method returns IHouseBuilder to allow method chaining
public interface IHouseBuilder
{
    IHouseBuilder WithWalls(int count);
    IHouseBuilder WithWindows(int count);
    IHouseBuilder WithDoors(int count);

    IHouseBuilder AddRoof();
    IHouseBuilder AddGarage();
    IHouseBuilder AddBackyard();
    IHouseBuilder AddSwimmingPool();
    IHouseBuilder AddPlumbing();
    IHouseBuilder AddHeatingSystem();
    IHouseBuilder AddElectricalWiring();

    House Build(); // Finalize and get the House object
}

// =========================
// 3. Concrete Builder
// =========================
// Implements the steps to build a House
public class HouseBuilder : IHouseBuilder
{
    // Private fields to store intermediate state
    private int _walls;
    private int _windows;
    private int _doors;
    private bool _hasRoof;
    private bool _hasGarage;
    private bool _hasBackyard;
    private bool _hasSwimmingPool;
    private bool _hasPlumbing;
    private bool _hasHeatingSystem;
    private bool _hasElectricalWiring;

    // Set mandatory counts
    public IHouseBuilder WithWalls(int count) { _walls = count; return this; }
    public IHouseBuilder WithWindows(int count) { _windows = count; return this; }
    public IHouseBuilder WithDoors(int count) { _doors = count; return this; }

    // Add optional features
    public IHouseBuilder AddRoof() { _hasRoof = true; return this; }
    public IHouseBuilder AddGarage() { _hasGarage = true; return this; }
    public IHouseBuilder AddBackyard() { _hasBackyard = true; return this; }
    public IHouseBuilder AddSwimmingPool() { _hasSwimmingPool = true; return this; }
    public IHouseBuilder AddPlumbing() { _hasPlumbing = true; return this; }
    public IHouseBuilder AddHeatingSystem() { _hasHeatingSystem = true; return this; }
    public IHouseBuilder AddElectricalWiring() { _hasElectricalWiring = true; return this; }

    // Build the House object
    public House Build()
    {
        // Create House instance with current state
        var house = new House(
            walls: _walls,
            windows: _windows,
            doors: _doors,
            hasRoof: _hasRoof,
            hasGarage: _hasGarage,
            hasBackyard: _hasBackyard,
            hasSwimmingPool: _hasSwimmingPool,
            hasPlumbing: _hasPlumbing,
            hasHeatingSystem: _hasHeatingSystem,
            hasElectricalWiring: _hasElectricalWiring
        );

        // Reset builder state to prevent reuse issues
        Reset();

        return house;
    }

    // Reset all fields to default
    private void Reset()
    {
        _walls = 0;
        _windows = 0;
        _doors = 0;
        _hasRoof = false;
        _hasGarage = false;
        _hasBackyard = false;
        _hasSwimmingPool = false;
        _hasPlumbing = false;
        _hasHeatingSystem = false;
        _hasElectricalWiring = false;
    }
}

// =========================
// 4. Director
// =========================
// Encapsulates standard ways to build a house
// Client can use Director to construct common house types
public class Director(IHouseBuilder builder)
{
    private readonly IHouseBuilder _builder = builder;

    // Construct a simple house
    public House ConstructSimpleHouse()
    {
        return _builder
            .WithWalls(4)
            .WithWindows(4)
            .WithDoors(1)
            .AddRoof()
            .AddPlumbing()
            .AddElectricalWiring()
            .Build();
    }

    // Construct a luxury house
    public House ConstructLuxuryHouse()
    {
        return _builder
            .WithWalls(8)
            .WithWindows(10)
            .WithDoors(3)
            .AddRoof()
            .AddGarage()
            .AddBackyard()
            .AddSwimmingPool()
            .AddPlumbing()
            .AddHeatingSystem()
            .AddElectricalWiring()
            .Build();
    }
}
