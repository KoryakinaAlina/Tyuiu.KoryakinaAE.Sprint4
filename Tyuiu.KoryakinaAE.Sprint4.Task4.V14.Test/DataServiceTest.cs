using Tyuiu.KoryakinaAE.Sprint4.Task4.V14.Lib;
namespace Tyuiu.KoryakinaAE.Sprint4.Task4.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] Array = new int[5, 5]{ { 3, 4, 4, 1, 6 },
                                           {8, 8, 9, 1, 3 },
                                           {8, 8, 8, 1, 3 },
                                           {8, 8, 8, 1, 3 },
                                           { 5, 8, 8, 1, 3 } };

            int[,] res = ds.Calculate(Array);
            int[,] wait = new int[5, 5]{ { 0, 4, 4, 0, 6 },
                                           {8, 8, 0, 0, 0 },
                                           {8, 8, 8, 0, 0 },
                                           {8, 8, 8, 0, 0 },
                                           { 0, 8, 8, 0, 0 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
