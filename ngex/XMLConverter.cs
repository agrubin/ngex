using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace ngex
{
    public class XMLConverter
    {
        // Fields...
        public LogObservable log = new LogObservable();
        public string regexpattern { get; private set; }

        public bool FromString(string xml)
        {
            try
            {
                XElement xmlTree = XElement.Parse(xml);
            }
            catch(Exception e)
            {
                log.Log(this, e, "Invalid format in xml string.");
                return false;
            }

            return true;
        }

        public void FromFile(string xmlFilename)
        {
        }

        public XMLConverter()
        {
            regexpattern = "";        
        }

        public override string ToString()
        {
            return regexpattern;
        }
    }
}
