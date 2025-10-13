using Microsoft.VisualStudio.TestTools.UnitTesting;
using GLS_CLI;

namespace GLS_CLI.Tests
{
    [TestClass]
    public class AutoAdatokTests
    {
        [TestMethod]
        public void Teszt_10L_100km_ShouldBe10()
        {
            double result = AutoAdatok.AtlagFogyasztas(10, 100);
            Assert.AreEqual(10, result, 0.001);
        }

        [TestMethod]
        public void Teszt_16L_200km_ShouldBe8()
        {
            double result = AutoAdatok.AtlagFogyasztas(16, 200);
            Assert.AreEqual(8, result, 0.001);
        }

        [TestMethod]
        public void Teszt_0L_0km_ShouldBe0()
        {
            double result = AutoAdatok.AtlagFogyasztas(0, 0);
            Assert.AreEqual(0, result);
        }
    }
}