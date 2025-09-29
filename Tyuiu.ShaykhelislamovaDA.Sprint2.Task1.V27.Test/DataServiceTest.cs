using Tyuiu.ShaykhelislamovaDA.Sprint2.Task1.V27.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint2.Task1.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 654;
            int b = 325;
            int c = 14;
            int d = 333;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { false, false, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
