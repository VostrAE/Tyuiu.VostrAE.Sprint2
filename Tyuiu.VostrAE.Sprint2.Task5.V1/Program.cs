using Tyuiu.VostrAE.Sprint2.Task5.V1.Lib;
class Program
{
    public static void Main()
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Исходные данные:                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите номер месяца:");
        int numMouth = Convert.ToInt32(Console.ReadLine());
        string res;
        if ((numMouth < 1) || (numMouth > 12))
        {
            res = "Введено неверное значение!";
        }
        else
        {
            res = "Этот месяц состоит из " + ds.FindMonthDaysCount(numMouth) + " дня(ей)";
        }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        
    }
}
