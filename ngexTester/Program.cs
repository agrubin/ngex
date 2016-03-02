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
            LogObservable.logEvent += LogHandler;
            TextWriterTraceListener myTextListener = new TextWriterTraceListener(System.Console.Out);
            Trace.Listeners.Add(myTextListener);

            XMLConverter converter = new XMLConverter();
            converter.FromString(@"<hithere</hi>");           
        }

        static void WriteLogEntry(string logEntry)
        {
            Trace.Write(logEntry);
            Trace.Flush();
        }

        static void LogHandler(object sender, LogEventArgs logeventargs)
        {
            StringBuilder logEntry = new StringBuilder();
            logEntry.Append(logeventargs.timeStamp).AppendLine();
            logEntry.Append("Class: " + sender.GetType().Name).AppendLine();
            logEntry.Append("Method: " + logeventargs.callerName).AppendLine();
            logEntry.Append("Description: " + logeventargs.description).AppendLine();
            logEntry.Append("Exception: " + logeventargs?.exception.Message).AppendLine();
            logEntry.Append("-------------------").AppendLine();
            WriteLogEntry(logEntry.ToString());
        }
    }
}
