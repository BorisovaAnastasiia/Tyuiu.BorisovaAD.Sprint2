using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BorisovaAD.Sprint2.Task0.V15.Lib
{
    public class DataService : ISprint2Task0V15
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            // Нужно получить массив:
            // (False, False, True, True, False, False)
            // при x = 3105, y = 275

            // Пробуем построить логические выражения из сравнений
            // и арифметики, сохраняя порядок операций в массиве.

            return new bool[]
            {
                x < y,           // 3105 < 275  => False
                x == y,          // 3105 == 275 => False
                x > y,           // 3105 > 275  => True
                (x - y) > 2800,  // 3105-275=2830 > 2800 => True
                (x + y) < 3000,  // 3105+275=3380 < 3000 => False
                (x != y) && (y == 1000) // 3105!=275 && 275==1000 => False
            };
        }
    }
}
