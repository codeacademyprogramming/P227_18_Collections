using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTask
{
    internal class MyList<T>
    {
        T[] _values;

        public MyList()
        {
            _values = new T[0];
        }

        public void Add(T value)
        {
            Array.Resize(ref _values,_values.Length+1);
            _values[_values.Length-1] = value;
        }

        public T this[int index]
        {
            get => _values[index];
            set => _values[index] = value;
        }
    }
}
