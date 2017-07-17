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
            return str.ToLower();
        }
    }
}
