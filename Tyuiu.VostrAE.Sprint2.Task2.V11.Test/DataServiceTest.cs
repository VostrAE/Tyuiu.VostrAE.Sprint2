using System.Security.Cryptography.X509Certificates;
using Tyuiu.VostrAE.Sprint2.Task2.V11.Lib;
namespace Tyuiu.VostrAE.Sprint2.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 9;
            int y = 3;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
