using FactoryMethod;

Console.WriteLine("Factory Method Pattern Demo: Logistics Management\n");

// Client code does not depend on concrete classes (Truck/Ship/Plane).
// It only interacts with factories and the ITransport interface.

// Example: Road logistics
LogisticsFactory roadFactory = new RoadLogistics();
ITransport roadTransport = roadFactory.CreateTransport();
roadTransport.Deliver();

// Example: Sea logistics
LogisticsFactory seaFactory = new SeaLogistics();
ITransport seaTransport = seaFactory.CreateTransport();
seaTransport.Deliver();

// Example: Air logistics
LogisticsFactory airFactory = new AirLogistics();
ITransport airTransport = airFactory.CreateTransport();
airTransport.Deliver();

// ✅ Benefit:
// Adding a new transport type only requires creating a new
// concrete transport class and a corresponding factory class.
// The existing client code remains unchanged (Open/Closed Principle).