using Tyuiu.KoryakinaAE.Sprint4.Task2.V19.Lib;

namespace Tyuiu.KoryakinaAE.Sprint4.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 6, 6, 9, 6, 9, 3, 8, 2, 9, 5, 7, 4, 4, 5 };
            int res = ds.Calculate(numsArray);
            int waitArray = 47;
            Assert.AreEqual(waitArray, res);
        }
    }
}
