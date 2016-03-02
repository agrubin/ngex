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
        public DateTime timeStamp { get; private set; }
        public Exception exception { get; private set; }
        public string callerName { get; private set; }
        public LogEventArgs(string description, Exception e, string callerName) 
        {
            this.description = description;
            this.exception = e ?? new Exception("none");
            this.timeStamp = DateTime.Now;
            this.callerName = callerName;
        }
    }
}
