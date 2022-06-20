using System;
using System.Collections.Generic;
using System.Text;

namespace LessonGeneric
{
    internal class MyIntList
    {
        public int[] _values;

        public int Count => _values.Length;

        public MyIntList()
        {
            _values = new int[0];
        }

        public void Add(int value)
        {
            Array.Resize(ref _values, _values.Length + 1);
            _values[_values.Length - 1] = value;
        }

        public int GetValue(int index)
        {
            if (Count > index && index > -1)
            {
                return _values[index];
            }
            throw new IndexOutOfRangeException();
        }

        public void Remove(int value)
        {
            int index = Array.IndexOf(_values, value);

            if (index < 0)
                throw new IndexOutOfRangeException();

            for (int i = index; i < _values.Length - 1; i++)
            {
                int swap = _values[i];
                _values[i] = _values[i + 1];
                _values[i + 1] = swap;
            }

            Array.Resize(ref _values, _values.Length - 1);
        }
    }
}
