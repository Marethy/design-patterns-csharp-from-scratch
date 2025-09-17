namespace Bridge;

// The 'Implementor' interface
// Defines the low-level interface that concrete classes must implement
public interface IMessageSender
{
    void SendMessage(string message);
}

// The 'ConcreteImplementor' classes
// These provide different implementations of IMessageSender
public class EmailSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Email sent with message: {message}");
    }
}

public class SmsSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"SMS sent with message: {message}");
    }
}

// The 'Abstraction' class
// Holds a reference to an IMessageSender, but does not know the details of how messages are sent
public class Notification(IMessageSender messageSender)
{
    // Reference to the implementor
    protected IMessageSender _messageSender = messageSender;

    // High-level operation that delegates the actual work to the implementor
    public virtual void Notify(string message)
        => _messageSender.SendMessage($"{message}");
}

// The 'Refined Abstraction' class
// Extends the abstraction to modify behavior while still relying on IMessageSender
public class UrgentNotification(IMessageSender messageSender) : Notification(messageSender)
{
    // Override to provide specialized behavior (urgent formatting)
    public override void Notify(string message)
    {
        _messageSender.SendMessage($"[URGENT] {message}");
    }
}
