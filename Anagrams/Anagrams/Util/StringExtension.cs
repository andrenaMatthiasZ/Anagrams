using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams.Util
{
    public static class StringExtension
    {
        public static string CalculateAnagramKey(this string str)
        {
            str = ReplaceOrRemoveUnwantedCharacters(str);

            string sortedString = SortString(str);

            return sortedString;
        }

        private static string SortString(string str)
        {
            Char[] characters = str.ToCharArray();
            Array.Sort(characters);

            return new String(characters);
        }

        private static string ReplaceOrRemoveUnwantedCharacters(string str)
        {   str = str.ToLower();
            str = str.Replace(" ", "");
            str = str.Replace("'", "");

            return str;
        }
    }
}
