using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShaykhelislamovaDA.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task6V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (n == 1)
            {
                switch (m)
                {
                    case 1: return $"{31}.{12}.{g - 1}";
                    case 2: return $"{31}.0{m - 1}.{g}";
                    case 3: return $"{28}.0{m - 1}.{g}";
                    case 4: return $"{31}.0{m - 1}.{g}";
                    case 5: return $"{30}.0{m - 1}.{g}";
                    case 6: return $"{31}.0{m - 1}.{g}";
                    case 7: return $"{30}.0{m - 1}.{g}";
                    case 8: return $"{31}.0{m - 1}.{g}";
                    case 9: return $"{31}.0{m - 1}.{g}";
                    case 10: return $"{30}.0{m - 1}.{g}";
                    case 11: return $"{31}.{m - 1}.{g}";
                    case 12: return $"{30}.{m - 1}.{g}";
                    default: throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
                }
            }
            else
                if (n > 10 && m < 10)
            {
                return $"{n - 1}.0{m}.{g}";
            }
            if (n < 11 && m < 10)
            {
                return $"0{n - 1}.0{m}.{g}";
            }
            if (n < 11 && m > 9)
            {
                return $"0{n - 1}.{m}.{g}";
            }
            if (n > 10 && m > 9)
            {
                return $"{n - 1}.{m}.{g}";
            }
            else
                return "?";
        }
    }
}
