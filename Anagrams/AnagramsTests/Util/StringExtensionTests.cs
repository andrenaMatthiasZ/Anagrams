using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagrams.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams.Util.Tests
{
    [TestClass()]
    public class StringExtensionTestCalculateAnagramKey
    {
        [TestMethod()]
        public void CaseIsIgnored()
        {
            Assert.AreEqual("a","A".CalculateAnagramKey());
        }

        [TestMethod()]
        public void SpaceIsIgnored()
        {
            Assert.AreEqual("a", " a ".CalculateAnagramKey());
        }

        [TestMethod()]
        public void OrderOfCharsIsIgnored()
        {
            Assert.AreEqual("ab", "ba".CalculateAnagramKey());
        }

        [TestMethod()]
        public void NumberOfCharactersIsRelevant()
        {
            Assert.AreNotEqual("a", "aa".CalculateAnagramKey());
        }



    }
}