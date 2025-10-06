using Tyuiu.VostrAE.Sprint2.Task1.V23.Lib;
class Program
{
    static void Main(string[] arg)
    {

        DataService ds = new DataService();
        int a = 242; int b = 571; int c = 325; int d = 155;
        bool[] res = ds.GetLogicOperations(a, b, c, d);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Исходные данные:                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("A =" + a);
        Console.WriteLine("B =" + b);
        Console.WriteLine("C =" + c);
        Console.WriteLine("D =" + d);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Разультат:                                                              *");
        Console.WriteLine("***************************************************************************");
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
            
        }
        Console.ReadKey();
    }
}
       