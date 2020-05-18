using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit;
using Moq;
using _3mTrening;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //int wynikDodawania = 2;
            var result = _3mTrening.Program.Dodawanie(2,4);
            int expectedResult = 6;
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestSprawdzenie()
        {
            var resultSprawdzenie = _3mTrening.Program.Sprawdzenie(99);
            Assert.IsFalse(resultSprawdzenie);

        }
        [TestMethod]
        public void TestSprawdzenief()
        {
            var resultSprawdzenief = _3mTrening.Program.Sprawdzenie(101);
            Assert.IsTrue(resultSprawdzenief);
        }
        [TestMethod]
        public void IloscWierszywDB()
        {
           
            var mock = new Mock<Inowyinterface>();
            mock.Setup(x => x.dodawanieczegos(It.IsAny<int>(),It.IsAny<int>())).Returns(7);
            var wynikdodawania = new _3mTrening.Naszinterface();
            var resultdodawania = wynikdodawania.dodawanieczegos(2, 4);
            Assert.AreEqual(6, resultdodawania);
        }

        [Test]
        public void TestProductBusiness()
        {

            var mockDataAccess = new Mock<IProductDataAccess>();
            mockDataAccess.Setup(m => m.CreateProduct(It.IsAny<Product>())).Returns(true);
            var productBusiness = new ProductBusiness(mockDataAccess.Object);

            Assert.IsTrue(expectedResult, wynikDodawania);

        }
         
    }
}
