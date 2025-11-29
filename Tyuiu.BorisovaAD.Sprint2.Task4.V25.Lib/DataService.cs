using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BorisovaAD.Sprint2.Task4.V25.Lib
{
    public class DataService : ISprint2Task4V25
    {
        public double Calculate(double x, double y)
        {
            // Условие: x - 20 * 2 < y < 4  =>  x - 40 < y < 4
            // Формула 1 (если true): z = (1 + 2/x^2)^y
            // Формула 2 (если false): z = y + ((x+1)/(y+2))^x

            // Используем тернарный оператор для выбора формулы
            double z = (x - 40 < y && y < 4) ?
                Math.Pow(1 + 2 / Math.Pow(x, 2), y) :
                y + Math.Pow((x + 1) / (y + 2), x);

            return z;
        }
    }
}
