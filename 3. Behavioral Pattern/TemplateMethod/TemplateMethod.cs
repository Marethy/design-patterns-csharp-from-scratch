namespace TemplateMethod;
public abstract class CaffeineBeverage
{
    // The template method defines the skeleton of an algorithm.
    public void PrepareBeverage()
    {
        BoilWater();
        Brew();
        PourInCup();
        if (CustomerWantsCondiments())
        {
            AddCondiments();
        }
    }
    protected abstract void Brew();
    protected abstract void AddCondiments();
    private void BoilWater() => Console.WriteLine("Boiling water");
    private void PourInCup() => Console.WriteLine("Pouring into cup");
    // Hook method: subclasses can override this to change the default behavior.
    protected virtual bool CustomerWantsCondiments() => true;
}
public class Tea : CaffeineBeverage
{
    protected override void Brew() => Console.WriteLine("Steeping the tea");
    protected override void AddCondiments() => Console.WriteLine("Adding lemon");
    protected override bool CustomerWantsCondiments()
    {
        Console.Write("Would you like lemon with your tea (y/n)? ");
        var answer = Console.ReadLine();
        return answer?.ToLower() == "y";
    }
}
public class Coffee : CaffeineBeverage
{
    protected override void Brew() => Console.WriteLine("Dripping Coffee through filter");
    protected override void AddCondiments() => Console.WriteLine("Adding Sugar and Milk");
}   
