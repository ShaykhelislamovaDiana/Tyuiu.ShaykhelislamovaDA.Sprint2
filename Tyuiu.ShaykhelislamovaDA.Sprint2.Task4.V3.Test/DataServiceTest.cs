using Tyuiu.ShaykhelislamovaDA.Sprint2.Task4.V3.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint2.Task4.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = 1.5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
;        }
    }
}
