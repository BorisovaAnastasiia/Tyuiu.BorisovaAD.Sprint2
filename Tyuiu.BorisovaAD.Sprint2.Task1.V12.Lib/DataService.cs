using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BorisovaAD.Sprint2.Task1.V12.Lib
{
    public class DataService : ISprint2Task1V12
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            result[0] = a > b;
            result[1] = c != d;
            result[2] = (a + b) < c;
            result[3] = (d - b) == a;
            result[4] = (c > d) && (a < 1000);
            result[5] = (d % 100) > a;

            return result;
        }
    }
}
