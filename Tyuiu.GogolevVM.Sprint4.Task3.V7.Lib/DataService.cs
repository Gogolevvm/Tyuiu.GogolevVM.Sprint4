using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GogolevVM.Sprint4.Task3.V7.Lib
{
    public class DataService : ISprint4Task3V7
    {
        public int Calculate(int[,] array)
        {
            int count = 0;
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] % 2 != 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
