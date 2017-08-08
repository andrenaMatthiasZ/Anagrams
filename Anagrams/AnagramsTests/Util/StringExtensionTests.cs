using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        public void OuterSpaceIsIgnored()
        {
            Assert.AreEqual("a", " a ".CalculateAnagramKey());
        }

        [TestMethod()]
        public void InnerSpaceIsIgnored()
        {
            Assert.AreEqual("ab", "a b".CalculateAnagramKey());
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

        [TestMethod()]
        public void ApostrophGetsDeleted()
        {
            Assert.AreEqual("aa", "a'a".CalculateAnagramKey());
        }

        [TestMethod()]
        public void SpecialLettersAreCountedAsNormalOnes()
        {
            // These are the special letters used in http://codekata.com/data/wordlist.txt.
            Assert.AreEqual("aaeoou", "åÅéöÖÜ".CalculateAnagramKey());
        }


    }
}