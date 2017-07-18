using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagrams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams.Tests
{
    [TestClass()]
    public class AnagramContainerTests
    {
        private const string DEFAULT_STRING = "abc";
        private const string ANAGRAM_OF_DEFAULT_STRING = "acb";
        private const string NOT_ANAGRAM_OF_DEFAULT_STRING = "abd";

        AnagramContainer container;

    
        [TestInitialize()]
        public void SetUp()
        {
            container = new AnagramContainer();
        }

        [TestMethod()]
        public void AddedStringsGetReturned()
        {
            container.Add(DEFAULT_STRING);

            Assert.AreEqual(DEFAULT_STRING, container.ToString());
        }

        [TestMethod()]
        public void StringsWhichAreAnagramsGetReturnedInSameLine()
        {
            container.Add(DEFAULT_STRING);
            container.Add(ANAGRAM_OF_DEFAULT_STRING);

            Assert.AreEqual(DEFAULT_STRING + ", " + ANAGRAM_OF_DEFAULT_STRING, container.ToString());
        }

        [TestMethod()]
        public void StringsWhichAreNotAnagramsGetReturnedInSeperateLine()
        {
            container.Add(DEFAULT_STRING);
            container.Add(NOT_ANAGRAM_OF_DEFAULT_STRING);

            Assert.AreEqual(DEFAULT_STRING + "\n" + NOT_ANAGRAM_OF_DEFAULT_STRING, container.ToString());
        }
    }
}