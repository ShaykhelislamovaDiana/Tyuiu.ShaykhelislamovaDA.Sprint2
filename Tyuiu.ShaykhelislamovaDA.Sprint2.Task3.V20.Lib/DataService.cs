using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShaykhelislamovaDA.Sprint2.Task3.V20.Lib
{
    public class DataService : ISprint2Task3V20
    {
        public double Calculate(double x)
        {
            double res = 0;
            if (x > 1)
            {
                res = Math.Round(x * Math.Pow((x + 1) / (x - 1), x), 3);
            }
            else
            {
                if (x == 0)
                {
                    res = Math.Round((x * x - Math.Cos(x * x) + 10) / (x * x - Math.Sin(x * x) + 12), 3);
                }
                else
                {
                    if ((-24 < x) && (x < 2))
                    {
                        res = Math.Round(Math.Pow(1 + 1 / x / x, x), 3);
                    }
                    else
                    {
                        if (x < -24)
                        {
                            res = Math.Round(x + 10 * x - 1 / x);
                        }
                    }
                }

            }
            return res;
        }
    }
}
