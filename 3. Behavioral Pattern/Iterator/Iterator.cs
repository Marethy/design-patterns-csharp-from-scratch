namespace Iterator;

public interface IIterator<T>
{
    bool HasNext();
    T? Next();
}

public class ConcreteIterator<T>(List<T> items) : IIterator<T>
{
    private int _position = 0;

    public bool HasNext()
    {
        return _position < items.Count;
    }

    public T? Next()
    {
        if (!HasNext()) return default;
        return items[_position++];
    }
}
