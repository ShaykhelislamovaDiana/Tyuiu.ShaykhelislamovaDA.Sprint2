using System.Data.Common;
using Tyuiu.ShaykhelislamovaDA.Sprint2.Task1.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int a = 654;
        int b = 325;
        int c = 14;
        int d = 333;
        Console.Title = "Спринт #2 | Выолнила: Шайхелисламова Д. А. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Логические операции                                                     *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #27                                                             *");
        Console.WriteLine("* Выполнила: Шайхелисламова Диана Артуровна | ПКТБ-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*          *");
        Console.WriteLine("*       *");
        Console.WriteLine("*         *");
        Console.WriteLine("*                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* a = 654, b = 325, c = 14, d = 333                                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);
        for (int i=0; i<6; i++)
        {
            Console.WriteLine(res[i]);
        }
    }
}
