using Tyuiu.VostrAE.Sprint2.Task1.V23.Lib;

namespace Tyuiu.VostrAE.Sprint2.Task1.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 242; int b = 571; int c = 325; int d = 155;
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = { false, false, false, true, true, true }; 

            CollectionAssert.AreEqual(wait, res);
        }
    }
}