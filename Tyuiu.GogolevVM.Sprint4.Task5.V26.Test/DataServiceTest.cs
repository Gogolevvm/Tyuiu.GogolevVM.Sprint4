using Tyuiu.GogolevVM.Sprint4.Task5.V26.Lib;
namespace Tyuiu.GogolevVM.Sprint4.Task5.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] wait = new int[3, 3] { { 0, 1, 1 }, { -1, -2, -3 }, { -5, 1, 0 } };
            DataService ds = new DataService();
            int[,] mtrx = new int[3,3] { { 0, 1, 3 }, { -1,-2,-3}, {-5,9,0 } };
            int[,] res = ds.Calculate(mtrx);

            CollectionAssert.AreEqual(wait,res);
            
        }
    }
}
