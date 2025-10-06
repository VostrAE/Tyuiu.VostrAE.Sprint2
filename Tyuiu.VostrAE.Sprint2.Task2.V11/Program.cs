using Tyuiu.VostrAE.Sprint2.Task2.V11.Lib;
class Program
{
    public static void Main()
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Исходные данные:                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите число X:");
        int X = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число Y:");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");
        bool res = ds.CheckDotInShadedArea(X, y);
        if (res) Console.WriteLine("Точка находится в заштрихованной области");
        else Console.WriteLine("Точка не находится в заштрихованной области");
        Console.ReadKey(); }
}
