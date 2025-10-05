using Microsoft.Testing.Platform.Extensions.Messages;
using Tyuiu.ShaykhelislamovaDA.Sprint2.Task6.V10.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint2.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2000;
            int m = 12;
            int n = 25;
            var wait = $"{n}.{m}.{g}";
            var res = ds.FindDateOfPreviousDay(g, m, n);
        }
    }
}
