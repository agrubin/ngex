using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Diagnostics;
using System.Text;
using ngex;


namespace ngexTester
{
    
    class Program
    {
        static void Main(string[] args)
        {
            LogObservable.logevent += LogHandler;
            TextWriterTraceListener myTextListener = new TextWriterTraceListener(System.Console.Out);
            Trace.Listeners.Add(myTextListener);

            XMLConverter converter = new XMLConverter();
            converter.FromString(@"<hithere</hi>");           
        }

        static void LogHandler(object sender, LogEventArgs logeventargs)
        {
            StringBuilder logentry = new StringBuilder();
            logentry.Append(logeventargs.timestamp).AppendLine();
            logentry.Append(logeventargs.description).AppendLine();
            logentry.Append(logeventargs?.exception.Message).AppendLine();
            logentry.Append("-------------------").AppendLine();
            Trace.Write(logentry);
            Trace.Flush();
        }
    }
}
