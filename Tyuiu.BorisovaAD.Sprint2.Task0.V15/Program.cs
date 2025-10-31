using Tyuiu.BorisovaAD.Sprint2.Task0.V15.Lib;

    DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Борисова А. Д. | Смартб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Операции сравнения                                                *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #15                                                             *");
Console.WriteLine("* Выполнил: Борисова Анастасия Дмитриевна | Смартб-25-1                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических      *");
Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):        *");
Console.WriteLine("* вернет логическую последовательность(массив): (True, False, True, True, *");
Console.WriteLine("* False, True), при x = 3105, y = 275 и печатает результат на экране.     *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x = 3105;
int y = 275;
Console.WriteLine($"X = {x}");
Console.WriteLine($"Y = {y}");

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

bool[] res = ds.GetCompareOperations(x, y);

Console.WriteLine("Логическая последовательность:");
for (int i = 0; i < res.Length; i++)
{
    Console.WriteLine($"[{i}] = {res[i]}");
}

Console.ReadKey();