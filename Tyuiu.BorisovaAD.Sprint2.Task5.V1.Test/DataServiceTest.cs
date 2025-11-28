using Tyuiu.BorisovaAD.Sprint2.Task5.V1.Lib;
namespace Tyuiu.BorisovaAD.Sprint2.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidMonthsWith31Days()
        {
            DataService ds = new DataService();
            // Январь, Март, Декабрь
            Assert.AreEqual(31, ds.FindMonthDaysCount(1));
            Assert.AreEqual(31, ds.FindMonthDaysCount(3));
            Assert.AreEqual(31, ds.FindMonthDaysCount(12));
        }

        [TestMethod]
        public void ValidMonthsWith30Days()
        {
            DataService ds = new DataService();
            // Апрель, Июнь, Ноябрь
            Assert.AreEqual(30, ds.FindMonthDaysCount(4));
            Assert.AreEqual(30, ds.FindMonthDaysCount(6));
            Assert.AreEqual(30, ds.FindMonthDaysCount(11));
        }

        [TestMethod]
        public void ValidMonthFebruary()
        {
            DataService ds = new DataService();
            // В данной реализации февраль всегда 28 дней
            Assert.AreEqual(28, ds.FindMonthDaysCount(2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidMonthNumberShouldThrowException()
        {
            DataService ds = new DataService();
            // Проверка обработки некорректного ввода (например, 0 или 13)
            // Этот тест ожидает, что вызов с некорректным значением вызовет ArgumentException
            ds.FindMonthDaysCount(0);
        }
    }
}
