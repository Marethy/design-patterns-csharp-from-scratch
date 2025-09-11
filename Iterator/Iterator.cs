using System;
using System.Collections.Generic;

namespace Iterator
{
    // 1. Iterator Interface
    public interface IIterator
    {
        bool HasNext();
        int Next();
    }

    // 2. Concrete Iterator với Primary Constructor
    public class NumberIterator(NumberCollection collection, int startIndex = 0) : IIterator
    {
        private readonly NumberCollection _collection = collection;
        private int _index = startIndex;

        public bool HasNext() => _index < _collection.Numbers.Count;

        public int Next() => _collection.Numbers[_index++];
    }

    // 3. Aggregate
    public class NumberCollection
    {
        public List<int> Numbers { get; } = new();

        public void Add(int number) => Numbers.Add(number);

        public IIterator GetIterator() => new NumberIterator(this);
    }

}