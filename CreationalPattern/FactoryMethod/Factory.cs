using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.FactoryMethod
{
    // STEP 1: Product (Abstract Class or Interface)
    public abstract class Transport
    {
        public abstract void Deliver();
    }

    // STEP 2: Concrete Products
    public class Car:Transport
    {
        public override void Deliver() => Console.WriteLine("Deliver by Car on road");
    }
    public class Truck : Transport
    {
        public override void Deliver() => Console.WriteLine("Deliver by Truck on road");
    }

    public class Ship : Transport
    {
        public override void Deliver() => Console.WriteLine("Deliver by Ship via sea");
    }

    // STEP 3: Creator (Abstract Factory Class)
    public abstract class Logistics
    {
        // Factory Method
        public abstract Transport CreateTransport();

        // Some logic that uses factory method
        public void PlanDelivery()
        {
            // Call factory method to get a product
            Transport transport = CreateTransport();

            // Use the product
            transport.Deliver();
        }
    }

    // STEP 4: Concrete Creators
    public class CarLogistics : Logistics
    {
        public override Transport CreateTransport() => new Car();
    }
    public class RoadLogistics : Logistics
    {
        public override Transport CreateTransport() => new Truck();
    }

    public class SeaLogistics : Logistics
    {
        public override Transport CreateTransport() => new Ship();
    }

}
