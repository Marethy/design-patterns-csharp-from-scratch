namespace ChainOfResponsibility;
public interface IHandler
{
    IHandler? SetNext(IHandler handler);
    void Handle(string request);
}
public abstract class AbstractHandler : IHandler
{
    private IHandler? _nextHandler;
    public IHandler? SetNext(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }
    public virtual void Handle(string request)
    {
        _nextHandler?.Handle(request);
    }
}
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
            base.Handle(request);
        }
    }
}
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
            base.Handle(request);

        }
    }
}
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
            base.Handle(request);

        }
    }
}
