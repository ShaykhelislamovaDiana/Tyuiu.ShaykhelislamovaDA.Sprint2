using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShaykhelislamovaDA.Sprint2.Task1.V27.Lib
{
    public class DataService : ISprint2Task1V27
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            //int a = 654; b = 325; c = 14; d = 333; false, false, true, false, true, false
            bool[] res = new bool[6];
            res[0] = a < b | c > d;
            res[1] = a == b & c > d;
            res[2] = a >= b || c == d;
            res[3] = a == b && c >= d;
            res[4] = !(res[0]);
            res[5] = a > b ^ c <= d;
            return res;
        }
    }
}
