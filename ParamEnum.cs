using System;
using System.Collections;

namespace Enom
{
    public class ParamEnum : IEnumerator
    {
        public Parameter[] _parameter;

        int position = -1;

        public ParamEnum(Parameter[] list)
        {
            _parameter = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _parameter.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Parameter Current
        {
            get
            {
                try
                {
                    return _parameter[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}

