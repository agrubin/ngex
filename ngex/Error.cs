using System;
using System.Collections.Generic;


namespace ngex
{
    delegate int foo(string s);
    public class Error
    {
        // Fields...
        static public event LogEventHandler logevent;

        public Exception caughtException { get; private set; }
        public string message { get; private set; }


        public Error(Exception e, string message)
        {
            caughtException = e;
            this.message = message;
            logevent?.Invoke(this, new LogEventArgs(message));
        }
    }

    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
