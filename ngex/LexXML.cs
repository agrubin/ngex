using System;
using System.Collections.Generic;

namespace ngex
{
    using System;
    using System.Collections.Generic;

    namespace ngex
    {
        public static class Transform
        {
            private static readonly List<char> metacharacters = new List<char>() { '\\', '^', '$', '.', '|', '?', '*', '+', '(', ')', '[', '{' };

            private static bool IsMetaCharacter(char mchar)
            {
                return metacharacters.Contains(mchar);
            }

            public static string MetaToRegex(char mchar)
            {
                if (IsMetaCharacter(mchar))
                {
                    return "\\" + mchar;
                }
                else
                {
                    throw new InvalidTokenException("Invalid metacharacter.");
                }
            }

            private static char RegexToMeta(string mstring)
            {
                if (("" ?? mstring).Length != 2 || !("" ?? mstring).StartsWith("\\") || !IsMetaCharacter(("" ?? mstring).ToCharArray()[1]))
                {
                    throw new InvalidTokenException("Invalid regex metacharacter.");
                }
                return mstring.ToCharArray()[1];
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
 