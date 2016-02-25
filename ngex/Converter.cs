using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace ngex
{
    public class XMLToRegexPattern
    {
        private string _Regex;

        public string Value
        {
            get { return _Regex; }
        }

        public XMLToRegexPattern(string XML)
        {
   
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
