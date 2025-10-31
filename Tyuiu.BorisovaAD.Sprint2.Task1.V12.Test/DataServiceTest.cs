using Tyuiu.BorisovaAD.Sprint2.Task1.V12.Lib;
namespace Tyuiu.BorisovaAD.Sprint2.Task1.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidTest()
        {
            DataService ds = new DataService();
            int a = 152, b = 116, c = 887, d = 556;
            bool[] wait = { true, true, true, false, true, false };
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
