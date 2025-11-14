using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Tyuiu.KoryakinaAE.Sprint4.Task6.V8.Lib;
namespace Tyuiu.KoryakinaAE.Sprint4.Task6.V8.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string[] array = new string[] { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" };
            var res = ds.Calculate(array);
            string[] tr = new string[] { "Пицца", "Пельмени", "Омлет", "Салат", "Роллы" };
            CollectionAssert.AreEqual(res, tr);

        }
    }
}
