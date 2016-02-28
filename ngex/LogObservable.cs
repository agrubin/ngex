using System;
using System.Collections.Generic;

namespace ngex
{
    public class LogObservable
    {
        // Fields...
        public event LogEventHandler logevent;

        public void Log(object observedtype, Exception caughtexception, string message)
        {
            logevent?.Invoke(observedtype, new LogEventArgs(message, caughtexception));
        }
    }
}
