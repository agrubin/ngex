using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Diagnostics;

namespace ngex
{
    public class XMLConverter : LogObservable
    {
        // Fields...
        public string regexPattern { get; private set; }

        public bool FromString(string xml)
        {
            try
            {
                XElement xmlTree = XElement.Parse(xml);
                Post(this, null, "Just parsed xml string.");
            }
            catch(Exception e)
            {
                Post(this, e, "Bad XML string input.");
                return false;
            }

            return true;
        }

        public void FromFile(string xmlFilename)
        {
        }

        public XMLConverter()
        {
            regexPattern = "";        
        }

        public override string ToString()
        {
            return regexPattern;
        }
    }
}
