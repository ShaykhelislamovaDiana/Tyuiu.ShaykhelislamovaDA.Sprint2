using Tyuiu.ShaykhelislamovaDA.Sprint2.Task5.V2.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint2.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int mon = 10;
            var res = ds.FindMonthSeason(mon);
            var wait = "Осень";
            Assert.AreEqual(wait, res);

        }
    }
}
