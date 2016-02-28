using System;
using System.Collections.Generic;

namespace ngex
{
    public class LogObservable
    {
        // Fields...
        public static event LogEventHandler logevent;

        protected void Post(object observedtype, Exception caughtexception, string message)
        {
            logevent?.Invoke(observedtype, new LogEventArgs(message, caughtexception));
        }
    }
}
