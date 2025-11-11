using System.Data.Common;
using tyuiu.cources.programming.interfaces.Sprint4;
using Tyuiu.GogolevVM.Sprint4.Task7.V0.Lib;
namespace Tyuiu.GogolevVM.Sprint4.Task7.V0.Lib
{
    public class DataService : ISprint4Task7V0
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

            int count = 0;
            for(int i = 0;i < n; i++)
            {
                for(int j = 0;j < m; j++)
                {
                    if (mtrx[i,j] == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
