using System;
using AbstractFactory;

// ================================================================
// Program.cs
// Demo of Abstract Factory Pattern (top-level statements style)
// ================================================================

// Create factories
var modernFactory = new ModernFurnitureFactory();
var victorianFactory = new VictorianFurnitureFactory();
var artDecoFactory = new ArtDecoFurnitureFactory();

Console.WriteLine("=== Modern Furniture Set ===");
var modernChair = modernFactory.CreateChair();
var modernSofa = modernFactory.CreateSofa();
var modernTable = modernFactory.CreateCoffeeTable();
modernChair.SitOn();
modernSofa.LieOn();
modernTable.PlaceItems();

Console.WriteLine("\n=== Victorian Furniture Set ===");
var victorianChair = victorianFactory.CreateChair();
var victorianSofa = victorianFactory.CreateSofa();
var victorianTable = victorianFactory.CreateCoffeeTable();
victorianChair.SitOn();
victorianSofa.LieOn();
victorianTable.PlaceItems();

Console.WriteLine("\n=== Art Deco Furniture Set ===");
var artDecoChair = artDecoFactory.CreateChair();
var artDecoSofa = artDecoFactory.CreateSofa();
var artDecoTable = artDecoFactory.CreateCoffeeTable();
artDecoChair.SitOn();
artDecoSofa.LieOn();
artDecoTable.PlaceItems();
