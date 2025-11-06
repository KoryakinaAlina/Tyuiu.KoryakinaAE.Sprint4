using Tyuiu.KoryakinaAE.Sprint4.Task0.V28.Lib;
namespace Tyuiu.KoryakinaAE.Sprint4.Task0.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            int res = ds.GetMultEvenArrEl(numsArray);
            int waitArray = 9216;
            Assert.AreEqual(waitArray, res);
        }
    }
}
