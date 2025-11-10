using Tyuiu.GogolevVM.Sprint4.Task5.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();


        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        Console.Write("Введите количество строк в массиве: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество столбцов в массиве: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        int[,] mtrx = new int[rows, columns];
        Console.WriteLine("********************************************************************************************");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                mtrx[i, j] = rnd.Next(-1,1);
            }
        }

        Console.WriteLine("\nМассив:");
        for(int i = 0;i < rows; i++)
        {
            for(int j = 0;j < columns; j++)
            {
                Console.Write($"{mtrx[i,j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");
        int res = ds.Calculate(mtrx);
        Console.WriteLine("Количество нулевых элементов = " + res);



    }
}