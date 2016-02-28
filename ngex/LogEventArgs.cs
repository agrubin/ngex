using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ngex
{
    public class LogEventArgs : EventArgs
    {
        // Fields...

        public string description { get; private set; }
        public DateTime timestamp { get; private set; }
        public Exception exception { get; private set; }

        public LogEventArgs()
        {
            this.description = "None.";
            this.timestamp = DateTime.Now;
        }
        public LogEventArgs(string description, Exception e)
        {
            this.description = description;
            this.exception = e;
            this.timestamp = DateTime.Now;
        }
    }
}
