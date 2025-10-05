using System.Net.WebSockets;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShaykhelislamovaDA.Sprint2.Task5.V2.Lib
{
    public class DataService : ISprint2Task5V2
    {
        public string FindMonthSeason(int value)
        {
            var res = "";
            switch (value)
            {
                case 1:
                    res = "зима";
                    break;
                case 2:
                    res = "зима";
                    break;
                case 3:
                    res = "весна";
                    break;
                case 4:
                    res = "весна";
                    break;
                case 5:
                    res = "весна";
                    break;
                case 6:
                    res = "лето";
                    break;
                case 7:
                    res = "лето";
                    break;
                case 8:
                    res = "лето";
                    break;
                case 9:
                    res = "осень";
                    break;
                case 10:
                    res = "осень";
                    break;
                case 11:
                    res = "осень";
                    break;
                case 12:
                    res = "зима";
                    break;
            }
            return res;
        }
    }
}
