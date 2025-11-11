using Tyuiu.BorisovaAD.Sprint2.Task2.V30.Lib;
namespace Tyuiu.BorisovaAD.Sprint2.Task2.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 6;
            int y = 9;
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
