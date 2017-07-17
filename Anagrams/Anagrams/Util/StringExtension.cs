using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams.Util
{
    public static class StringExtension
    {
        public static String CalculateAnagramKey(this String str)
        {
            String trimmedLowerCaseString = str.Trim().ToLower();

            Char[] characters = trimmedLowerCaseString.ToCharArray();
            Array.Sort(characters);

            return new String(characters);
        }
    }
}
