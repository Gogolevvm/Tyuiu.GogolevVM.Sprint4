using Tyuiu.GogolevVM.Sprint4.Task0.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");
        int[] numsArray = { 0, 5, 78, 0, 6 };
        Console.WriteLine("Исходный массив");
        for (int i = 0; i < numsArray.Length; i++) 
        {
            Console. WriteLine(numsArray[i]);
        }


        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("Результирующий массив: ");

        numsArray = ds.Calculate(numsArray);

        for (int i = 0;i < numsArray.Length - 1;i++)
        {
            Console.WriteLine(numsArray[i] + "\t");
        }

        Console.WriteLine();

    }
}