﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ngex;


namespace ngexTester
{
    class Program
    {
        static void Main(string[] args)
        {
            LexXML LX = new LexXML();

            char meta = Transform.RegexToMeta(@"\\");
        }
    }
}
