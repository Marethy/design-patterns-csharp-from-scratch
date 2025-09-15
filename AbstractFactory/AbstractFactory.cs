using System;

namespace AbstractFactory;
// ================================================================
// 1. Product Interfaces
// These define the general behaviors of furniture items.
// Each family of furniture (Chair, Sofa, CoffeeTable) must implement these.
// ================================================================
public interface IChair { void SitOn(); }
public interface ISofa { void LieOn(); }
public interface ICoffeeTable { void PlaceItems(); }

// ================================================================
// 2. Concrete Products - Modern
// Modern-style furniture implementation
// ================================================================
public class ModernChair : IChair
{
    public void SitOn() => Console.WriteLine("You sit on a modern chair.");
}

public class ModernSofa : ISofa
{
    public void LieOn() => Console.WriteLine("You lie on a modern sofa.");
}

public class ModernCoffeeTable : ICoffeeTable
{
    public void PlaceItems() => Console.WriteLine("You place items on a modern coffee table.");
}

// ================================================================
// 3. Concrete Products - Victorian
// Victorian-style furniture implementation
// ================================================================
public class VictorianChair : IChair
{
    public void SitOn() => Console.WriteLine("You sit on a victorian chair.");
}

public class VictorianSofa : ISofa
{
    public void LieOn() => Console.WriteLine("You lie on a victorian sofa.");
}

public class VictorianCoffeeTable : ICoffeeTable
{
    public void PlaceItems() => Console.WriteLine("You place items on a victorian coffee table.");
}

// ================================================================
// 4. Concrete Products - Art Deco
// Art Deco-style furniture implementation
// ================================================================
public class ArtDecoChair : IChair
{
    public void SitOn() => Console.WriteLine("You sit on an art deco chair.");
}

public class ArtDecoSofa : ISofa
{
    public void LieOn() => Console.WriteLine("You lie on an art deco sofa.");
}

public class ArtDecoCoffeeTable : ICoffeeTable
{
    public void PlaceItems() => Console.WriteLine("You place items on an art deco coffee table.");
}

// ================================================================
// 5. Abstract Factory Interface
// Defines a contract for creating families of related objects.
// Clients only depend on this interface, not on concrete classes.
// ================================================================
public interface IFurnitureFactory
{
    IChair CreateChair();
    ISofa CreateSofa();
    ICoffeeTable CreateCoffeeTable();
}

// ================================================================
// 6. Concrete Factories
// Each factory creates consistent families of furniture (Modern/Victorian/ArtDeco).
// ================================================================
public class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair() => new ModernChair();
    public ISofa CreateSofa() => new ModernSofa();
    public ICoffeeTable CreateCoffeeTable() => new ModernCoffeeTable();
}

public class VictorianFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair() => new VictorianChair();
    public ISofa CreateSofa() => new VictorianSofa();
    public ICoffeeTable CreateCoffeeTable() => new VictorianCoffeeTable();
}

public class ArtDecoFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair() => new ArtDecoChair();
    public ISofa CreateSofa() => new ArtDecoSofa();
    public ICoffeeTable CreateCoffeeTable() => new ArtDecoCoffeeTable();
}

