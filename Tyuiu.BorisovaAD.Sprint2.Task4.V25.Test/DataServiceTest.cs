using Tyuiu.BorisovaAD.Sprint2.Task4.V25.Lib;
namespace Tyuiu.BorisovaAD.Sprint2.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidConditionFalse()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 2;
            double numerator = 3 * x * x - Math.Cos(y * y) + 10;
            double denominator = y * y - Math.Pow(Math.Sin(x), 2) + 12;
            double wait = numerator / denominator;
            wait = Math.Round(wait, 3);
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
