using System;
using System.Collections.Generic;
using System.Text;

namespace LessonGeneric
{
    internal class MyHumanList
    {
        public Human[] _values;

        public int Count => _values.Length;

        public MyHumanList()
        {
            _values = new Human[0];
        }

        public void Add(Human value)
        {
            Array.Resize(ref _values, _values.Length + 1);
            _values[_values.Length - 1] = value;
        }

        public Human GetValue(int index)
        {
            if (Count > index && index > -1)
            {
                return _values[index];
            }
            throw new IndexOutOfRangeException();
        }

        public void Remove(Human value)
        {
            int index = Array.IndexOf(_values, value);

            if (index < 0)
                throw new IndexOutOfRangeException();

            for (int i = index; i < _values.Length - 1; i++)
            {
                Human swap = _values[i];
                _values[i] = _values[i + 1];
                _values[i + 1] = swap;
            }

            Array.Resize(ref _values, _values.Length - 1);
        }
    }
}
