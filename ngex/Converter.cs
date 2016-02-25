using System;
using System.Collections.Generic;

namespace ngex
{
    public class XMLToRegexPattern
    {
        // Fields...
        private string _Regex;

        public string Value
        {
            get { return _Regex; }
        }
        public XMLToRegexPattern(string XML)
        {
            _Regex = "aaa";
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
