using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {

            int wynikDodawania = 2;
                //.Dodawanie(2, 3);
            int expectedResult = 5;

            Assert.AreEqual(expectedResult, wynikDodawania);

        }
    }
}
