using Tyuiu.BorisovaAD.Sprint2.Task1.V12.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Борисова А.Д. | Смартб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Логические операции                                               *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #12                                                             *");
Console.WriteLine("* Выполнил: Борисова Анастасия Дмитриевна | Смартб-25-1                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений и логических операций,         *");
Console.WriteLine("* которая вернет логическую последовательность(массив): (True, True,      *");
Console.WriteLine("* True, False, True, False), при a = 152, b = 116, c = 887, d = 556       *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int a = 152, b = 116, c = 887, d = 556;
Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");
Console.WriteLine($"c = {c}");
Console.WriteLine($"d = {d}");

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

bool[] res = ds.GetLogicOperations(a, b, c, d);

Console.WriteLine("Логическая последовательность:");
for (int i = 0; i < res.Length; i++)
{
    Console.WriteLine($"[{i}] = {res[i]}");
}

Console.ReadKey();
