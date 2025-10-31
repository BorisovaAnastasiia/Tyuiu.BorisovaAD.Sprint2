using Tyuiu.BorisovaAD.Sprint2.Task0.V15.Lib;
namespace Tyuiu.BorisovaAD.Sprint2.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int x = 3105;
            int y = 275;
            var service = new DataService();

            // Act
            bool[] result = service.GetCompareOperations(x, y);

            // Assert
            bool[] expected = new bool[] { false, false, true, true, false, false };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
