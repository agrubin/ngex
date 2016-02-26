using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace ngex
{
    delegate void mydel();
    public class XMLConverter
    {
        // Fields...

        public string RegexPattern { get; private set; }

        public bool FromString(string xml)
        {
            try
            {
                XElement xmlTree = XElement.Parse(xml);
            }
            catch(Exception e)
            {
                new Error(e, "Invalid format in xml string.");
                return false;
            }

            return true;
        }

        public void FromFile(string xmlFilename)
        {
        }

        public XMLConverter()
        {
            RegexPattern = "";        
        }

        public override string ToString()
        {
            return RegexPattern;
        }
    }
}
