using System;

namespace Enom
{ 
    public static class Format
    {
        public static string Input(Parameters parameters)
        {
            string _queryString = "";
            char[] _end = { Convert.ToChar("&") };

            foreach (Parameter p in parameters)
            {
                _queryString += p.Key + "=" + p.Value + "&";
            }
            return _queryString.TrimEnd(_end);
        }

        public static void Output(Parameters parameters)
        { 
            //will format XML nodes as Node=Value and return string
        }
    }
}