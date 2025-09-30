using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShaykhelislamovaDA.Sprint2.Task2.V24.Lib
{
    public class DataService : ISprint2Task2V24
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;
            if ((((3<=x) && (x<=5) && (3<=y) && (y<=7)) || (6 <= x) && (x <= 8) && (5 <= y) && (y <= 10)))
            {
                res = true;
            }
            if ((((9 <= x) && (x <= 12) && (3 <= y) && (y <= 6)) || ((13 <= x) && (x <= 13) && (6 <= y) && (y <= 6))))
            {
                res = true;
            }
            if ((((3 <= x) && (x <= 7) && (11 <= y) && (y <= 11)) || ((7 <= x) && (x <= 7) && (12 <= y) && (y <= 12))))
            {
                res = true;
            }
            if ((((9 <= x) && (x <= 12) && (9 <= y) && (y <= 10)) || ((11 <= x) && (x <= 12) && (11 <= y) && (y <= 12))))
            {
                res = true;
            }
            return res;
        }
    }
}
