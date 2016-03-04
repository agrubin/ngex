using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ngex
{
    static public class LogObservable
    {
        // Fields...
         static private event LogEventHandler logEvent;

        /// <summary>
        /// Start a logger or multiple loggers by passing in a log event handler.
        /// </summary>
        /// <param name="lehDelegate"></param>
        static public void LogStart(LogEventHandler lehDelegate)
        {
            logEvent += lehDelegate;
        }

        static public void LogStop(LogEventHandler lehDelegate)
        { 
            logEvent -= lehDelegate;
        }

        /// <summary>
        /// The Post method is called at any point in the application which requires logging.  Note that
        /// Runtime services are used to derive the calling method since GetCurrentMethod seems to be unavailable
        /// in PCL reflection...not to mention that it is much slower anyway.
        /// </summary>
        /// <param name="observedType"></param>
        /// <param name="caughtException"></param>
        /// <param name="message"></param>
        /// <param name="callerName"></param>
        static internal void Post(object observedType, Exception caughtException, string message = "", [System.Runtime.CompilerServices.CallerMemberName] string callerName = "" )
        {
            logEvent?.Invoke(observedType, new LogEventArgs(message, caughtException, callerName));
        }
    }
}
