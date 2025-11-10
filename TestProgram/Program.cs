internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[] { 6,-5,5,0,-3,6 };
        int c = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                c++;
            }
        }
        Console.WriteLine(c);

    }
}