using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ngex
{
    public class LogEventArgs : EventArgs
    {
        private string callerName;

        // Fields...

        public string description { get; private set; }
        public DateTime timeStamp { get; private set; }
        public Exception exception { get; private set; }
  
        public LogEventArgs(string description, Exception e)
        {
            this.description = description;
            this.exception = e;
            this.timeStamp = DateTime.Now;
        }

        public LogEventArgs(string description, Exception e, string callerName) : this(description, e)
        {
            this.callerName = callerName;
        }
    }
}
