using System;

namespace FactoryMethod;

// 1. Transport Interface
// This defines the common contract for all types of transport.
public interface ITransport
{
    void Deliver();
}

// 2. Concrete Transport Implementations
// Each class represents a specific type of transportation.

public class Truck : ITransport
{
    public void Deliver() => Console.WriteLine("Delivering goods by land in a truck.");
}

public class Ship : ITransport
{
    public void Deliver() => Console.WriteLine("Delivering goods by sea in a ship.");
}

public class Plane : ITransport
{
    public void Deliver() => Console.WriteLine("Delivering goods by air in a plane.");
}

// 3. Creator (Factory)
// The abstract factory defines a method that must return a Transport object.
// Subclasses will implement this factory method to decide which transport to create.
public abstract class LogisticsFactory
{
    public abstract ITransport CreateTransport();
}

// 4. Concrete Factories
// Each concrete factory decides which transport object to instantiate.
public class RoadLogistics : LogisticsFactory
{
    public override ITransport CreateTransport() => new Truck();
}

public class SeaLogistics : LogisticsFactory
{
    public override ITransport CreateTransport() => new Ship();
}

public class AirLogistics : LogisticsFactory
{
    public override ITransport CreateTransport() => new Plane();
}