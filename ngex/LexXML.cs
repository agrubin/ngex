using System;
using System.Collections.Generic;

namespace ngex
{
    public static class Transform
    {
        private static readonly List<char> metacharacters = new List<char>() { '\\', '^', '$', '.', '|', '?', '*', '+', '(', ')', '[', '{' }; 
        
        public static string MetaCharacter(char mchar)
        {
            if (metacharacters.Contains(mchar))
            {
                return "\\" + mchar;
            }
            else
            {
                return mchar.ToString();
            }
        }
    }
    public class LexXML
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LexXML"/> class.
        /// </summary>
        public LexXML()
        {
            
        }
    }
}
 