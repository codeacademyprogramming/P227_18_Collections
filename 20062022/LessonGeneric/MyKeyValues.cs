using System;
using System.Collections.Generic;
using System.Text;

namespace LessonGeneric
{
    internal class MyKeyValues<TK,TV>
    {
        TK[] _keys;
        TV[] _values;

        public MyKeyValues()
        {
            _keys = new TK[0];
            _values = new TV[0];
        }

        public void Add(TK key,TV value)
        {
            Array.Resize(ref _keys, _keys.Length+1); ;
            _keys[_keys.Length-1] = key;

            Array.Resize(ref _values, _values.Length + 1); ;
            _values[_values.Length - 1] = value;
        }

        public TV GetValue(TK key)
        {
            int index = Array.IndexOf(_keys, key);

            if (index < 0)
                throw new IndexOutOfRangeException();

            return _values[index];
        }

    }
}
