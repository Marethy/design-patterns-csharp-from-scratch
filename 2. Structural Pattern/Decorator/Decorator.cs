namespace Decorator;

// The 'Component' interface
// Defines the contract for MilkTea and its decorators
public interface IMilkTea
{
    string Description { get; }
    decimal Cost { get; }
    string ToDisplay() => $"{Description} : {Cost}";


}

// The 'ConcreteComponent'
// The base milk tea that can be decorated
public class MilkTea(string description, decimal cost) : IMilkTea
{
    public string Description { get; set; } = description;
    public decimal Cost { get; set; } = cost;
}

// The 'Decorator' interface
// Ensures all decorators also implement IMilkTea
public interface IMilkTeaDecorator : IMilkTea
{
    IMilkTea MilkTea { get; set; }
}

// The 'ConcreteDecorator' classes
public class PearlDecorator(IMilkTea milkTea) : IMilkTeaDecorator
{
    public IMilkTea MilkTea { get; set; } = milkTea;

    public string Description => MilkTea.Description + ", pearl";
    public decimal Cost => MilkTea.Cost + 3;

}

public class PuddingDecorator(IMilkTea milkTea) : IMilkTeaDecorator
{
    public IMilkTea MilkTea { get; set; } = milkTea;

    public string Description => MilkTea.Description + ", pudding";
    public decimal Cost => MilkTea.Cost + 4;

}

public class CoconutDecorator(IMilkTea milkTea) : IMilkTeaDecorator
{
    public IMilkTea MilkTea { get; set; } = milkTea;

    public string Description => MilkTea.Description + ", coconut";
    public decimal Cost => MilkTea.Cost + 5;

}
