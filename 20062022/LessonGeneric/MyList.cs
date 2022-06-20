using System;
using System.Collections.Generic;
using System.Text;

namespace LessonGeneric
{
    internal class MyList<T>
    {
        public T[] _values;

        public int Count => _values.Length;

        public MyList()
        {
            _values = new T[0];
        }

        public void Add(T value)
        {
            Array.Resize(ref _values, _values.Length + 1);
            _values[_values.Length - 1] = value;
        }

        public T GetValue(int index)
        {
            if (Count > index && index > -1)
            {
                return _values[index];
            }
            throw new IndexOutOfRangeException();
        }

        public void Remove(T value)
        {
            int index = Array.IndexOf(_values, value);

            if (index < 0)
                throw new IndexOutOfRangeException();

            for (int i = index; i < _values.Length - 1; i++)
            {
                T swap = _values[i];
                _values[i] = _values[i + 1];
                _values[i + 1] = swap;
            }

            Array.Resize(ref _values, _values.Length - 1);
        }
    }
}
