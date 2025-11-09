using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GogolevVM.Sprint4.Task1.V22.Lib
{
    public class DataService : ISprint4Task1V22
    {
        public int Calculate(int[] array)
        {
            int p = 1;
            for (int i = 2; i < array.Length - 2; i++)
            {
                if (array[i] % 2 != 0)
                {
                    p *= array[i];
                }
            }
            return p;
        }
    }
}
