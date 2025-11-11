using Tyuiu.BorisovaAD.Sprint2.Task2.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Борисова А.Д. | Смартб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Операции сравнения                                                *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #24                                                             *");
        Console.WriteLine("* Выполнил: Борисова Анастасия Дмитриевна | Смартб-25-1                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры     *");
        Console.WriteLine("* и вычисляет, находится ли точка с координатами X,Y в заштрихованной     *");
        Console.WriteLine("* области.                                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите координату X: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите координату Y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        bool result = ds.CheckDotInShadedArea(x, y);

        if (result)
            Console.WriteLine($"Точка ({x},{y}) находится в заштрихованной области");
        else
            Console.WriteLine($"Точка ({x},{y}) не находится в заштрихованной области");

        Console.ReadKey();
    }
}