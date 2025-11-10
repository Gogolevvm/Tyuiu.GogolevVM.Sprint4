using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GogolevVM.Sprint4.Task2.V0.Lib
{
    public class DataService : ISprint4Task2V0
    {
        public int Calculate(int[] array)
        {
            int sumArray = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 10)
                {
                    sumArray+= array[i];
                }
            }
            return sumArray;
        }
        
        
    }
}
