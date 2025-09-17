namespace ChainOfResponsibility;

// The Handler interface declares methods for building the chain
// and for handling a request.
public interface IHandler
{
    // Set the next handler in the chain and return it
    IHandler? SetNext(IHandler handler);

    // Process the request or pass it to the next handler
    void Handle(string request);
}

// The base class implements default behavior of chaining handlers.
// Subclasses only need to override the Handle method.
public abstract class AbstractHandler : IHandler
{
    private IHandler? _nextHandler;

    // Link the next handler and return it so we can chain fluently
    public IHandler? SetNext(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    // By default, just pass the request to the next handler
    public virtual void Handle(string request)
    {
        _nextHandler?.Handle(request);
    }
}

// A concrete handler that processes request "A"
public class ConcreteHandlerA : AbstractHandler
{
    public override void Handle(string request)
    {
        if (request == "A")
        {
            Console.WriteLine("ConcreteHandlerA handled the request.");
        }
        else
        {
            Console.WriteLine("ConcreteHandlerA passed the request");
            base.Handle(request); // forward to next handler
        }
    }
}

// A concrete handler that processes request "B"
public class ConcreteHandlerB : AbstractHandler
{
    public override void Handle(string request)
    {
        if (request == "B")
        {
            Console.WriteLine("ConcreteHandlerB handled the request.");
        }
        else
        {
            Console.WriteLine("ConcreteHandlerB passed the request");
            base.Handle(request); // forward to next handler
        }
    }
}

// A concrete handler that processes request "C"
public class ConcreteHandlerC : AbstractHandler
{
    public override void Handle(string request)
    {
        if (request == "C")
        {
            Console.WriteLine("ConcreteHandlerC handled the request.");
        }
        else
        {
            Console.WriteLine("ConcreteHandlerC passed the request");
            base.Handle(request); // forward to next handler
        }
    }
}
