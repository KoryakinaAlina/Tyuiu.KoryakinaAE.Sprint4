using Tyuiu.KoryakinaAE.Sprint4.Task7.V1.Lib;

namespace Tyuiu.KoryakinaAE.Sprint4.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "135792468";
            int wait = 4;

            var res = ds.Calculate(3, 3, str);
            Assert.AreEqual(wait, res);
        }
    }
}
