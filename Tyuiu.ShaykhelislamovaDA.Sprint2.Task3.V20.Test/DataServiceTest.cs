using Tyuiu.ShaykhelislamovaDA.Sprint2.Task3.V20.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint2.Task3.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 0;
            double wait = 0.75;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
