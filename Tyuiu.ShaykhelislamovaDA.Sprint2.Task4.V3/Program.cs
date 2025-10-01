using Tyuiu.ShaykhelislamovaDA.Sprint2.Task4.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выолнила: Шайхелисламова Д. А. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тернарный оператор                                                      *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнила: Шайхелисламова Диана Артуровна | ПКТБ-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с клавиатуры   *");
        Console.WriteLine("* с использованием тернарного оператора, где пользователь вводит значение *");
        Console.WriteLine("* переменных х,у, если x < y - 1 то z = y + (y - 1)/(x + 2), иначе        *");
        Console.WriteLine("* х + 2y(1/(y + 3). Ответ округлите до 3 знаков после запятой.            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите значение х:");
        int x = 0;
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение y:");
        int y = 0;
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(x, y));
    }
}