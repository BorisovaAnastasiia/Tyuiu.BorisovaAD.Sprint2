using Tyuiu.BorisovaAD.Sprint2.Task7.V13.Lib;
namespace Tyuiu.BorisovaAD.Sprint2.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidPointsInArea()
        {
            DataService ds = new DataService();

            // Точка внутри верхней левой части: (-0.5, 0.5)
            Assert.IsTrue(ds.CheckDotInShadedArea(-0.5, 0.5));

            // Точка на границе окружности в верхней левой части: (-1, 0)
            Assert.IsTrue(ds.CheckDotInShadedArea(-1, 0));

            // Точка внутри нижнего правого треугольника: (0.5, -0.2)
            Assert.IsTrue(ds.CheckDotInShadedArea(0.5, -0.2));

            // Точка на границе линии y = x - 1: (1, 0)
            Assert.IsTrue(ds.CheckDotInShadedArea(1, 0));
        }

        [TestMethod]
        public void ValidPointsOutsideArea()
        {
            DataService ds = new DataService();

            // Точка вне круга: (2, 2)
            Assert.IsFalse(ds.CheckDotInShadedArea(2, 2));

            // Точка внутри круга, но в пустой области (верхний правый): (0.5, 0.5)
            Assert.IsFalse(ds.CheckDotInShadedArea(0.5, 0.5));

            // Точка внутри круга, но в пустой области (нижний левый): (-0.5, -0.5)
            Assert.IsFalse(ds.CheckDotInShadedArea(-0.5, -0.5));

            // Точка ниже линии y = x - 1: (0.5, -0.6)
            Assert.IsFalse(ds.CheckDotInShadedArea(0.5, -0.6));
        }
}
