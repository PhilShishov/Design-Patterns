﻿using System.Collections.Generic;

namespace IteratorPattern
{
    public class ConcreteAggregate<T> : IAggregate<T>
    {
        private readonly List<T> items = new List<T>();

        public IIterator<T> CreateIterator()
        {
            return new ConcreteIterator<T>(this);
        }

        public T this[int index]
        {
            get => items[index];
            set => items[index] = value;
        }

        public int Count => items.Count;

        public void Add(T item)
        {
            items.Add(item);
        }
    }
}
