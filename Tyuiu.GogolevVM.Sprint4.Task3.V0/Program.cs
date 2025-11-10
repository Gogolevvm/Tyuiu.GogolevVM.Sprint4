using Tyuiu.GogolevVM.Sprint4.Task3.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int[,] mtrx = new int[3, 3] { { 0,1,2},
                                     { 3,0,5},
                                     { 3,4,5}        };
        int rows = mtrx.GetUpperBound(0)+1;
        int columns = mtrx.Length / rows;

        DataService ds = new DataService();

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        Console.WriteLine("Массив: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mtrx[i,j]} \t");
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