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

        public void TraceMessage(string message,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0)
        {
            System.Diagnostics.Trace.WriteLine("message: " + message);
            System.Diagnostics.Trace.WriteLine("member name: " + memberName);
            System.Diagnostics.Trace.WriteLine("source file path: " + sourceFilePath);
            System.Diagnostics.Trace.WriteLine("source line number: " + sourceLineNumber);
        }
        static void LogHandler(object sender, LogEventArgs logeventargs)
        {
           
            StringBuilder logentry = new StringBuilder();
            logentry.Append(logeventargs.timeStamp).AppendLine();
            logentry.Append(logeventargs.description).AppendLine();
            logentry.Append(logeventargs?.exception.Message).AppendLine();
            logentry.Append("-------------------").AppendLine();
            Trace.Write(logentry);
            Trace.Flush();

        }
    }
}
