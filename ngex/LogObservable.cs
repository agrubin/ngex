using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ngex
{
    public class LogObservable
    {
        /// <summary>
        /// Subscribe to logevent for logging.
        /// </summary>
        // Fields...
         static event LogEventHandler logevent;

        protected void Post(object observedtype, Exception caughtexception, string message)
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);

            return sf.GetMethod().Name;
            logevent?.Invoke(observedtype, new LogEventArgs(message, caughtexception));
        }
    }
}
