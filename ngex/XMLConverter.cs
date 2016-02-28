using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Diagnostics;

namespace ngex
{
    public class XMLConverter
    {
        // Fields...
        public string regexpattern { get; private set; }

        internal LogObservable log = new LogObservable();

        public bool FromString(string xml)
        {
            try
            {
                XElement xmlTree = XElement.Parse(xml);
                log.Post(this, null, "Just parsed xml string.");
            }
            catch(Exception e)
            {
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
