using Tyuiu.VostrAE.Sprint2.Task4.V29.Lib;
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
        double res = ds.Calculate(x,y);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Значение функции= " + res);
        Console.ReadKey();
    }
}
