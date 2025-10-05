using Tyuiu.ShaykhelislamovaDA.Sprint2.Task7.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выолнила: Шайхелисламова Д. А. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнила: Шайхелисламова Диана Артуровна | ПКТБ-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
        Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами  *");
        Console.WriteLine("* X,Y в заштрихованной области.                                           *");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите значение х:");
        double x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение y:");
        double y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.CheckDotInShadedArea(x, y));
    }
}