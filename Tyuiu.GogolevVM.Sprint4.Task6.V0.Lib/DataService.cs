using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GogolevVM.Sprint4.Task6.V0.Lib
{
    public class DataService : ISprint4Task6V0
    {
        public int Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array,x => x.Length == 7);
            return mas.Length;
        }
    }
}
