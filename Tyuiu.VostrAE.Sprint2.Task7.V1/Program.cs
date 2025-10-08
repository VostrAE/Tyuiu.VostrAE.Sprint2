using Tyuiu.VostrAE.Sprint2.Task7.V1.Lib;
class Program
{
    public static void Main()
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Исходные данные:                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите число X:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число Y:");
        int y = Convert.ToInt32(Console.ReadLine());
        bool res = ds.CheckDotInShadedArea(x,y);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");
        if (res) { Console.WriteLine("Точка находится в заштрихованной облати"); }
        else { Console.WriteLine("Точка находится в заштрихованной облати"); }
        Console.ReadKey(); 
    }
}
