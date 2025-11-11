using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BorisovaAD.Sprint2.Task3.V4.Lib
{
    public class DataService : ISprint2Task3V4
    {
        public double Calculate(double x)
        {
            double y;

            if (x == 0)
            {
                // Вторая ветка: y = (x^2 - cos(x^2) + 10) / (x^2 - sin(x^2) + 12)
                double numerator = Math.Pow(x, 2) + Math.Cos(Math.Pow(x, 2));
                double denominator = Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12;
                y = numerator / denominator;
            }
            else if (x > 1)
            {
                // Первая ветка: y = x * [(x+1)/(x-1)]^x
                double temp = (x + 1) / (x - 1);
                y = x + Math.Pow(temp, x);
            }
            else if (x < -24)
            {
                // Четвертая ветка: y = x + 10x - 1/x
                y = x + 10 * x - (1 / x);
            }
            else // -24 < x < 2 и x ≠ 0
            {
                // Третья ветка: y = (1 + 1/x^2)^x
                y = Math.Pow(x + 1 / Math.Pow(x, 2), x);
            }

            return Math.Round(y, 3);
        }
    }
}
