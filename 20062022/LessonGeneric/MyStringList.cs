using System;
using System.Collections.Generic;
using System.Text;

namespace LessonGeneric
{
    internal class MyStringList
    {
        public string[] _values;

        public int Count => _values.Length;

        public MyStringList()
        {
            _values = new string[0];
        }

        public void Add(string value)
        {
            Array.Resize(ref _values, _values.Length + 1);
            _values[_values.Length - 1] = value;
        }

        public string GetValue(int index)
        {
            if(Count>index && index > -1)
            {
                return _values[index];
            }
            throw new IndexOutOfRangeException();
        }

        public void Remove(string value)
        {
            int index = Array.IndexOf(_values, value);

            if (index < 0)
                throw new IndexOutOfRangeException();

            for (int i = index; i < _values.Length-1; i++)
            {
                string swap = _values[i];
                _values[i] = _values[i + 1];
                _values[i + 1] = swap;
            }

            Array.Resize(ref _values, _values.Length - 1);
        }

    }
}
