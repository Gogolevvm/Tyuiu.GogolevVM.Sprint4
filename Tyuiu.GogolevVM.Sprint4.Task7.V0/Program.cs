using Tyuiu.GogolevVM.Sprint4.Task7.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int rows = 3;
        int columns = 3;
        int[,] mtrx = new int[rows, columns];

        string str = "103050709";

        DataService ds = new DataService();
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        int index = 0;

        Console.WriteLine("\nМассив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine($"{str[index]} \t");
                index++;
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        int res = ds.Calculate(rows, columns, str);

        Console.WriteLine("Количество нулевых элементов = " + res);
    }
}