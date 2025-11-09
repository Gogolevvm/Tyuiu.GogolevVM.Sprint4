using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GogolevVM.Sprint4.Task0.V0.Lib
{
    public class DataService : ISprint4Task0V0
    {
        public int[] Calculate(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++) 
            {
                if (array[i] == 0)
                {
                    array[i] = 1;
                }
            }
            return array;
        }
    }
}
