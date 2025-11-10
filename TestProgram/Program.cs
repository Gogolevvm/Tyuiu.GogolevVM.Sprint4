internal class Program
{
    private static void Main(string[] args)
    {
        int[,] array = new int[,] { { -7,8,-1 }, { -3,-7,8 }, { -7,-2,8 } };
        int s = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i,j] % 2 == 0)
                {
                    s += array[i, j];
                } 
            }
        }
        Console.WriteLine(s);

    }
}