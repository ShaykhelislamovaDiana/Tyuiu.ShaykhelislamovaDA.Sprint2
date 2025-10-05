using Tyuiu.ShaykhelislamovaDA.Sprint2.Task6.V10.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint2.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            int g = 2000;
            int m = 12;
            int n = 25;
            var wait = $"{n-1}.{m}.{g}";
            var res = ds.FindDateOfPreviousDay(g, m, n);
        }
    }
}