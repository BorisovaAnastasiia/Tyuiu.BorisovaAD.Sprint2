using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BorisovaAD.Sprint2.Task4.V25.Lib
{
    public class DataService : ISprint2Task4V25
    {
        public double Calculate(double x, double y)
        {
            //double z = Math.Sqrt(x) > 2 * y
            //    ? Math.Pow(7 + 2 / (y * y), x)
            //    : (3 * x * x - Math.Cos(y * y) + 10)
            //      / (y * y - Math.Pow(Math.Sin(x), 2) + 12);

            double z = Math.Sqrt(x) > 2.0 * y
                ? Math.Pow(7.0 + (2.0 / (y * y)), x)
                : ((3.0 * x * x - Math.Cos(y) * Math.Cos(y) + 10.0)
                / (y * y - Math.Sin(x * x) + 12.0));

            return Math.Round(z, 3);
        }
    }
}
