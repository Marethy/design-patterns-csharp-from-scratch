using Singleton;
// Access Singleton multiple times
var s1 = SingletonClass.Instance;
SingletonClass.DoSomething();

var s2 = SingletonClass.Instance;
SingletonClass.DoSomething();

// Check if both variables point to the same instance
Console.WriteLine(ReferenceEquals(s1, s2)
    ? "Both references point to the same instance."
    : "Different instances (this should not happen).");