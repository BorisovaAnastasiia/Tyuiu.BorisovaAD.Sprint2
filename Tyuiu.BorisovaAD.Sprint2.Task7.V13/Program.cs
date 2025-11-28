using Tyuiu.BorisovaAD.Sprint2.Task7.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Задание #7 | Вариант #13 | Борисова А. Д.";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Дополнительное задание. Операторы if, switch, логические           *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнил: Борисова Анастасия Дмитриевна | Смартб-23-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные (вещест-  *");
        Console.WriteLine("* венные значения) и вычисляет, находится ли точка с координатами Х,Y     *");
        Console.WriteLine("* в заштрихованной области.                                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите координату X: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координату Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        // Проверяем, находится ли точка в области
        bool isInArea = ds.CheckDotInShadedArea(x, y);

        if (isInArea)
        {
            Console.WriteLine($"Точка ({x}, {y}) находится в заштрихованной области.");
        }
        else
        {
            Console.WriteLine($"Точка ({x}, {y}) НЕ находится в заштрихованной области.");
        }

        Console.ReadKey();
    }
}