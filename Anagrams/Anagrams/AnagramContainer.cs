using System;
using System.Collections.Generic;
using System.Text;
using Anagrams.Util;

namespace Anagrams
{
    public class AnagramContainer
    {
        private const string SAME_ANAGRAM_SEPERATOR = ", ";
        private const string DIFFERENT_ANAGRAM_SEPERATOR = "\r\n";

        Dictionary<String, List<String>> AnagramCollection = new Dictionary<String, List<String>>();

            public void Add(string str)
        {
            string anagramkey = str.CalculateAnagramKey();
            if (AnagramCollection.ContainsKey(anagramkey))
            {
                AnagramCollection.TryGetValue(anagramkey, out List<string> Anagrams);
                Anagrams.Add(str);
            }
            else {
                AnagramCollection.Add(anagramkey, new List<string> { str });
            }

        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            AppendAnagrams(stringBuilder);

            return stringBuilder.ToString();
        }

        private void AppendAnagrams(StringBuilder stringBuilder)
        {
            foreach (var anagrams in AnagramCollection.Values)
            {
                AppendLine(stringBuilder, anagrams);

                stringBuilder.Append(DIFFERENT_ANAGRAM_SEPERATOR);
            }

            RemoveLast(stringBuilder, DIFFERENT_ANAGRAM_SEPERATOR.Length);
        }

        private static void AppendLine(StringBuilder stringBuilder, List<string> anagrams)
        {
            foreach (string @string in anagrams)
            {
                AppendAnagram(stringBuilder, @string);
            }
          
            RemoveLast(stringBuilder, SAME_ANAGRAM_SEPERATOR.Length);
        }

        private static void RemoveLast(StringBuilder stringBuilder, int length)
        {
            stringBuilder.Remove(stringBuilder.Length - length, length);
        }

        private static void AppendAnagram(StringBuilder stringBuilder, string @string)
        {
            stringBuilder.Append(@string);
            stringBuilder.Append(SAME_ANAGRAM_SEPERATOR);
        }
    }
}
