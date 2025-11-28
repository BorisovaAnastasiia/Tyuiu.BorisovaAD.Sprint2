using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BorisovaAD.Sprint2.Task7.V13.Lib
{
    public class DataService : ISprint2Task7V13
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Условия для верхней левой части круга
            bool area1 = (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (x <= 0) && (y >= 0);

            // Условия для нижнего правого треугольника
            bool area2 = (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (x >= 0) && (y <= 0) && (y >= x - 1);

            // Точка находится в заштрихованной области, если она принадлежит area1 ИЛИ area2
            return area1 || area2;
        }
    }
}
