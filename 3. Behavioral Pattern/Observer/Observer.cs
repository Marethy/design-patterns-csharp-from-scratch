namespace Observer;
public interface IPublisher
{
    string Name { get; }
    void Publish(string content);
    void Subscribe(ISubscriber subscriber);
    void Unsubscribe(ISubscriber subscriber);
}

public class Publisher(string name) : IPublisher
{
    private readonly List<ISubscriber> _subscribers = [];

    public string Name { get; } = name;

    public void Publish(string content)
    {
        foreach (var s in _subscribers.ToList())
            s.Update(this, content);
    }

    public void Subscribe(ISubscriber subscriber) => _subscribers.Add(subscriber);
    public void Unsubscribe(ISubscriber subscriber) => _subscribers.Remove(subscriber);
}

public interface ISubscriber
{
    string Name { get; }
    void Update(IPublisher publisher, string content);
    void SubscribeTo(IPublisher publisher);
    void UnsubscribeFrom(IPublisher publisher);
}

public class Subscriber(string name) : ISubscriber
{
    public string Name { get; } = name;

    public void SubscribeTo(IPublisher publisher) => publisher.Subscribe(this);
    public void UnsubscribeFrom(IPublisher publisher) => publisher.Unsubscribe(this);

    public void Update(IPublisher publisher, string content)
    {
        Console.WriteLine($"{Name} got news from {publisher.Name}: {content}");
    }
}
