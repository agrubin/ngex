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
        public string exception { get; private set; }
        public string targetsite { get; private set; }
        public string callerName { get; private set; }
        public LogEventArgs(string description, Exception e, string callerName ) 
        {
            if (e == null)
            {
               this.description = description;
               this.exception = "None";
            }
            else
            {
                this.description = e.Message;
                this.exception = e.GetType().FullName;
            }
 
            this.timeStamp = DateTime.Now;
            this.callerName = callerName;
        }
    }
}
