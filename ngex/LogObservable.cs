using System;
using System.Collections.Generic;

namespace ngex
{
    internal class LogObservable
    {
        // Fields...
        public event LogEventHandler logevent;

        public void Post(object observedtype, Exception caughtexception, string message)
        {
            logevent?.Invoke(observedtype, new LogEventArgs(message, caughtexception));
        }
    }
}
