using Tyuiu.BorisovaAD.Sprint2.Task4.V25.Lib;
namespace Tyuiu.BorisovaAD.Sprint2.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidConditionTrue()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = -25;
            // Условие (10 - 40 < -25 && -25 < 4) => (-30 < -25 && -25 < 4) => True && True => True
            // Ожидаемое значение: (1 + 2/100)^-25 = ~0.608035...
            double expected = 0.6080350741490212;

            double actual = ds.Calculate(x, y);

            // Используем Assert.AreEqual с погрешностью (например, 0.0001) для сравнения вещественных чисел
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void ValidConditionFalse()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 10;
            // Условие (5 - 40 < 10 && 10 < 4) => (-35 < 10 && 10 < 4) => True && False => False
            // Ожидаемое значение: y + ((x+1)/(y+2))^x = 10 + ((5+1)/(10+2))^5 = 10 + (6/12)^5 = 10 + 0.5^5 = 10 + 0.03125 = 10.03125
            double expected = 10.03125;

            double actual = ds.Calculate(x, y);

            Assert.AreEqual(expected, actual, 0.0001);
        }
    }
}
