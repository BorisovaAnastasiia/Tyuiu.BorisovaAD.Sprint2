using Tyuiu.BorisovaAD.Sprint2.Task6.V11.Lib;
namespace Tyuiu.BorisovaAD.Sprint2.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidStandardDay()
        {
            DataService ds = new DataService();
            // 10 марта 2024 -> 11 марта 2024
            string res = ds.FindDateOfNextDay(2024, 3, 10);
            Assert.AreEqual("11.3.2024", res);
        }

        [TestMethod]
        public void ValidEndOfMonth()
        {
            DataService ds = new DataService();
            // 31 января 2024 -> 1 февраля 2024
            string resJan = ds.FindDateOfNextDay(2024, 1, 31);
            Assert.AreEqual("1.2.2024", resJan);

            // 30 апреля 2024 -> 1 мая 2024
            string resApr = ds.FindDateOfNextDay(2024, 4, 30);
            Assert.AreEqual("1.5.2024", resApr);

            // 28 февраля 2024 -> 1 марта 2024 (год не високосный по условию)
            string resFeb = ds.FindDateOfNextDay(2024, 2, 28);
            Assert.AreEqual("1.3.2024", resFeb);
        }

        [TestMethod]
        public void ValidEndOfYear()
        {
            DataService ds = new DataService();
            // 31 декабря 2024 -> 1 января 2025
            string res = ds.FindDateOfNextDay(2024, 12, 31);
            Assert.AreEqual("1.1.2025", res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidDayOfMonth()
        {
            DataService ds = new DataService();
            // 31 апреля (в апреле 30 дней)
            ds.FindDateOfNextDay(2024, 4, 31);
        }
}
