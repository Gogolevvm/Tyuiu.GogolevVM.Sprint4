using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GogolevVM.Sprint4.Task7.V10.Lib
{
    public class DataService : ISprint4Task7V10
    {
        public int Calculate(int n, int m, string value)
        {
            
            int[,] mtrx = new int[n, m];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i,j] = int.Parse(value.Substring(index,1));
                    index++;
                }
            }
            int sum = 0;

            for (int i = 0;i < n; i++)
            {
                for (int j = 0;j < m; j++)
                {
                    if (mtrx[i,j] % 2 != 0)
                    {
                        sum = sum + mtrx[i,j];
                    }
                }
            }
            return sum;



        }
    }
}
