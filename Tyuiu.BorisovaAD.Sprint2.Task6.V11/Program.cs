using Tyuiu.BorisovaAD.Sprint2.Task6.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Задание #6 | Вариант #11 | Борисова А. Д.";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Сокращенная форма оператора switch                                *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнил: Борисова Анастасия Дмитриевна | Смартб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана дата (год g, месяц m, день n). Определить дату следующего дня.     *");
        Console.WriteLine("* Год не високосный.                                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите год (g): ");
        int g = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите месяц (m): ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите день (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        try
        {
            string nextDayDate = ds.FindDateOfNextDay(g, m, n);
            Console.WriteLine($"Дата следующего дня: {nextDayDate}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        Console.ReadKey();
    }
}