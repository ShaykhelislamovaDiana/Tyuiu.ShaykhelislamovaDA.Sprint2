using System.Xml.Schema;
using Tyuiu.ShaykhelislamovaDA.Sprint2.Task2.V24.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint2.Task2.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 1;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(false, res);
        }
    }
}
