using Tyuiu.BorisovaAD.Sprint2.Task4.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Борисова А.Д. | Смартб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Тернарный оператор                                                *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнил: Борисова Анастасия Дмитриевна | Смартб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение                *");
        Console.WriteLine("* с использованием тернарного оператора. Пользователь вводит значение     *");
        Console.WriteLine("* переменных X,Y с клавиатуры. Если sqrt(X) > Y*2, то                     *");
        Console.WriteLine("* z = (7 + 2/Y^2)^X, иначе z = (3X^2 - cos(Y^2) + 10)/(Y^2 - sin^2(X) + 12)*");
        Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите значение X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        double result = ds.Calculate(x, y);

        Console.WriteLine($"Значение Z = {result}");

        Console.ReadKey();
    }
}