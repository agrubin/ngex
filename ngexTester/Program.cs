using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Diagnostics;
using ngex;


namespace ngexTester
{
    
    class Program
    {
    
        static void Main(string[] args)
        {
            XMLConverter converter = new XMLConverter();
            
            TextWriterTraceListener myTextListener = new TextWriterTraceListener(System.Console.Out);
            Trace.Listeners.Add(myTextListener);

            // Write output to the file.
            Trace.Write("Test output ");


            // Flush the output.
            Trace.Flush();
        }
    }
}
