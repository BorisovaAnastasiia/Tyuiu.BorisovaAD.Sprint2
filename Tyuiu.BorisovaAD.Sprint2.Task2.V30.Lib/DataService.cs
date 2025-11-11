using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BorisovaAD.Sprint2.Task2.V30.Lib
{
    public class DataService : ISprint2Task2V30
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (y == 3) return (x >= 3 && x <= 5) || (x >= 9 && x <= 12);
            if (y == 4) return (x >= 3 && x <= 5) || (x >= 9 && x <= 12);
            if (y == 5) return x >= 3 && x <= 12;
            if (y == 6) return x >= 3 && x <= 13;
            if (y == 7) return x >= 3 && x <= 8;
            if (y == 8) return x >= 6 && x <= 8;
            if (y == 9) return x >= 6 && x <= 12;
            if (y == 10) return x >= 6 && x <= 12;
            if (y == 11) return (x >= 3 && x <= 7) || (x >= 11 && x <= 12);
            if (y == 12) return x == 7 || (x >= 11 && x <= 12);
            return false;
        }
    }
}
