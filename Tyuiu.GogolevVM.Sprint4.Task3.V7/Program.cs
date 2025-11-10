using Tyuiu.GogolevVM.Sprint4.Task3.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { 9,6,9,3,7},
                                         { 3, 3, 3, 8, 2},
                                         { 2, 1, 3, 5, 2},
                                         { 6, 2, 3, 2, 5},
                                         { 4, 5, 6, 9, 5} };
        int rows = mtrx.GetUpperBound(0) + 1;
        int columns = mtrx.Length / rows;

        

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        Console.WriteLine("Массив: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mtrx[i, j]} \t");
            }

            Console.WriteLine();
        }
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        int res = ds.Calculate(mtrx);

        Console.WriteLine("Количество нулевых элеменотов" + res);
    }
}