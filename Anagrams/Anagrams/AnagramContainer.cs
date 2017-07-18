using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anagrams.Util;

namespace Anagrams
{
    public class AnagramContainer
    {
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
            string str= "";

            foreach (String anagramkey in AnagramCollection.Keys)
            {
                AnagramCollection.TryGetValue(anagramkey, out List<string> anagrams);
                foreach(string @string in anagrams)
                {
                    str += @string + " "; 
                }
                str += "\n";
            }

            str = str.Substring(0, str.Length - " \n".Length);

            return str;
        }
    }
}
