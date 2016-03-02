using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ngex
{
    static public class LogObservable
    {
        /// <summary>
        /// Subscribe to logevent for logging.
        /// </summary>
        // Fields...
         static public event LogEventHandler logEvent;

        /// <summary>
        /// The Post method is called at any point in the application which requires logging.  Note that
        /// Runtime services are used to derive the calling method since GetCurrentMethod seems to be unavailable
        /// in PCL reflection...not to mention that it is much slower anyway.
        /// </summary>
        /// <param name="observedType"></param>
        /// <param name="caughtException"></param>
        /// <param name="message"></param>
        /// <param name="callerName"></param>
        static internal void Post(object observedType, Exception caughtException, string message, [System.Runtime.CompilerServices.CallerMemberName] string callerName = "" )
        {
            logEvent?.Invoke(observedType, new LogEventArgs(message, caughtException, callerName));
        }
    }
}
