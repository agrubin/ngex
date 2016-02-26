using System;
using System.Collections.Generic;
using System.Linq;

namespace ngex
{
    public class LogEventArgs : EventArgs
    {
        // Fields...

        public string description { get; private set; }
        public DateTime timestamp { get; private set; }

        public LogEventArgs()
        {
            description = "None.";
            timestamp = DateTime.Now;
        }
        public LogEventArgs(string description)
        {
            this.description = description;
            timestamp = DateTime.Now;
        }
    }
}
