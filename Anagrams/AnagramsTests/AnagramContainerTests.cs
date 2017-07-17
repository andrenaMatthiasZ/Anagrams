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
        [TestMethod()]
        public void AddedStringsGetReturned()
        {
            AnagramContainer container = new AnagramContainer();

            container.Add("abc");

            Assert.AreEqual("abc", container.ToString());
        }

    }
}