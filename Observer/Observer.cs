using System;
using System.Collections.Generic;

public interface IPublisher
{
    void Subscribe(ISubscriber subscriber);
    void Unsubscribe(ISubscriber subscriber);
    void Notify(string message);
}

public interface ISubscriber
{
    void Update(string message);
}

public class SocialMedia : IPublisher
{
    private readonly HashSet<ISubscriber> _subscribers = new();

    public void Subscribe(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }

    public void Notify(string message)
    {
        foreach (var subscriber in _subscribers)
        {
            subscriber.Update(message);
        }
    }
}

public class User : ISubscriber
{
    private readonly string _name;

    public User(string name) => _name = name;

    public void Update(string message)
    {
        Console.WriteLine($"{_name} received: {message}");
    }
}

