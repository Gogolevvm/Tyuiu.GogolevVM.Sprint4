using tyuiu.cources.programming.interfaces.Sprint4;
using Tyuiu.GogolevVM.Sprint4.Task5.V0.Lib;
namespace Tyuiu.GogolevVM.Sprint4.Task5.V0.Lib
{
    public class DataService : ISprint4Task5V0
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int cols = array.Length / rows;

            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i,j] == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
