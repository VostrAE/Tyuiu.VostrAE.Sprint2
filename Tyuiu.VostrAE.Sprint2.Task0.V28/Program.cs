using Tyuiu.VostrAE.Sprint2.Task0.V28.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 111;
        int y = 735;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Исходные данные:                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("X =" + x);
        Console.WriteLine("Y =" + y);
       
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Разультат:                                                              *");
        Console.WriteLine("***************************************************************************");
for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        Console.ReadKey();

    }
}
}