internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[] { 2,4,3,7,5,9 };
        int m = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0 && array[i] < m)
                m = array[i];
        }
        Console.WriteLine(m);
    }
}