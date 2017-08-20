using System.Collections;

namespace Enom
{

    public class Parameters : IEnumerable
    {
        private Parameter[] _parameter;
        public Parameters(Parameter[] paramArray)
        {
            _parameter = new Parameter[paramArray.Length];

            for (int i = 0; i < paramArray.Length; i++)
            {
                _parameter[i] = paramArray[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public ParamEnum GetEnumerator()
        {
            return new ParamEnum(_parameter);
        }
    }
}
