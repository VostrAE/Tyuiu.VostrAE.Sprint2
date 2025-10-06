using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VostrAE.Sprint2.Task1.V23.Lib
{
    public class DataService : ISprint2Task1V23
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {        
            bool[] res = new bool[6];
            res[0] = a == b | a == c;
            res[1] = d != c + 246 & a == b;
            res[2] = b < a || d > c;
            res[3] = a > d && b > c;
            res[4] = a + 80 <= c;
            res[5] = c >= b ^ 100 < b;
            return res;
        }
    }
}

