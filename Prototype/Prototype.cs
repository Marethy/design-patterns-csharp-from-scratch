using System;

namespace Prototype;

// Prototype interface
public interface IPrototype<T>
{
    T Clone();
}

// Base Person class implements Prototype
public class Laptop(string brand, string model, int ram, int storage) : IPrototype<Laptop>
{
    public string Brand { get; set; } = brand;
    public string Model { get; set; } = model;
    public int RAM { get; set; } = ram;
    public int Storage { get; set; } = storage;

    // Shallow copy
    public virtual Laptop Clone()
    {
        return (Laptop)this.MemberwiseClone();
    }
    public override string ToString()
    {
        return $"{Brand} {Model}, RAM: {RAM}GB, Storage: {Storage}GB";
    }
}