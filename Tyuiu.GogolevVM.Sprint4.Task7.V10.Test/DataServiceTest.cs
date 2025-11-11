using Tyuiu.GogolevVM.Sprint4.Task7.V10.Lib;
namespace Tyuiu.GogolevVM.Sprint4.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "695847142536";
            int rows = 3;
            int cols = 4;
            int[,] mtrx = new int[rows, cols];
            int res = ds.Calculate(rows, cols, str);
            int wait = 30;
            Assert.AreEqual(wait, res);
        }
    }
}
