using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _3mTrening
{
    [TestFixture]
    public class Testy
    {
        [Test]
        public void TestowanieDodawania()
        {
            int wynikDodawania = Program.Dodawanie(2, 3);
            int expectedResult = 5;

            Assert.AreEqual(expectedResult, wynikDodawania);
        }
    }
}
