﻿using System;
using System.Collections.Generic;

namespace ngex
{
    using System;
    using System.Collections.Generic;

    public static class Transform
    {
        private static readonly List<char> metacharacters = new List<char>() { '\\', '^', '$', '.', '|', '?', '*', '+', '(', ')', '[', '{' };

        private static bool IsMetaCharacter(char testMeta)
        {
            return metacharacters.Contains(testMeta);
        }

        public static string MetaToRegex(char meta)
        {
            if (IsMetaCharacter(meta))
            {
                return @"\" + meta;
            }
            else
            {
                throw new InvalidTokenException("Invalid metacharacter.");
            }
        }

        /// <summary>
        /// Input regex string must be 2 characters long with first char = '\' and second char a metacharacter.
        /// </summary>
        /// <param name="regexMeta"></param>
        /// <returns>char</returns>
        public static char RegexToMeta(string regexMeta)
        {
            if ((regexMeta ?? "").Length != 2 || !(regexMeta ?? "").StartsWith(@"\") || !IsMetaCharacter((regexMeta ?? "").ToCharArray()[1]))
            {
                throw new InvalidTokenException("Invalid regex metacharacter.");
            }
            return regexMeta.ToCharArray()[1];
        }
    }

    public class LexXML
    {
        public LexXML()
        {

        }
    }
    
}
 