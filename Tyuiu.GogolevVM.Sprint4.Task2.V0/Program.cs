using Tyuiu.GogolevVM.Sprint4.Task2.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        Console.Write("Введите количество элементов массива: ");
        int len = Convert.ToInt32(Console.ReadLine());

        int[] numsArray = new int[len];

        for (int i = 0; i < len; i++)
        {
            numsArray[i] = rnd.Next(5,20);
        }

        Console.WriteLine("Массив");
        for (int i = 0;i < len; i++)
        {
            Console.Write(numsArray[i] + "\t");
        }

        Console.WriteLine();
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        int res  = ds.Calculate(numsArray);

        Console.WriteLine("Сумма элементов больше 10 = " + res);
        
    }
}