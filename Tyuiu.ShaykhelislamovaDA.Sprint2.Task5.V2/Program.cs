using Tyuiu.ShaykhelislamovaDA.Sprint2.Task5.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выолнила: Шайхелисламова Д. А. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тернарный оператор                                                      *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнила: Шайхелисламова Диана Артуровна | ПКТБ-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* По данному месяцу, определите в какую пору года попадает этот месяц     *");
        Console.WriteLine("* (Зима, Лето, Весна, Осень).                                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int value = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.FindMonthSeason(value));
    }
}