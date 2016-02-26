using System;
using System.Collections.Generic;
using System.Linq;
using ngex;

namespace ngexTester
{
    class Program
    {
        static void MainLogHandler(object sender, LogEventArgs le)
        {
            Console.WriteLine(le.timestamp + " - " + le.description);
        } 
        static void Main(string[] args)
        {

            Error.logevent += MainLogHandler;
            new Error(null, "test");
            int g = 7;
        }
    }
}
