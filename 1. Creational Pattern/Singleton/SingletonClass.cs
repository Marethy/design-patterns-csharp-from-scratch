namespace Singleton;

public sealed class SingletonClass
{
    private static readonly SingletonClass _instance = new();

    // Private constructor ensures that the class cannot be instantiated from outside
    private SingletonClass()
    {
        Console.WriteLine("Singleton instance created!");
    }

    public static SingletonClass Instance => _instance;

    public static void DoSomething()
    {
        // Implementation here
        Console.WriteLine("Singleton instance is doing something.");
    }
}