using Tyuiu.BorisovaAD.Sprint2.Task3.V4.Lib;
namespace Tyuiu.BorisovaAD.Sprint2.Task3.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateXZero()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 0.75;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
