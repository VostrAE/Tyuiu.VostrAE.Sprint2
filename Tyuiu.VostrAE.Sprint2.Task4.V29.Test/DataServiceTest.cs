using Tyuiu.VostrAE.Sprint2.Task4.V29.Lib;
namespace Tyuiu.VostrAE.Sprint2.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = -100;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = -175.98;
            Assert.AreEqual(res, wait);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 100;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 9999;
            Assert.AreEqual(res, wait);
        }
    }
}
