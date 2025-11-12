using Tyuiu.KoryakinaAE.Sprint4.Task5.V24.Lib;
namespace Tyuiu.KoryakinaAE.Sprint4.Task5.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = {
                { -7, 5, 3, -1, 3 },
                { 2, 6, -5, -4, 3 },
                { 3, -2, -4, 6, 4 },
                { 3, 3, 5, -2, -1 },
                { 5, -1, 4, -3, -6 } };
            int res = ds.Calculate(matrix);
            int wait = 14;
            Assert.AreEqual(res, wait);
        }
    }
}
