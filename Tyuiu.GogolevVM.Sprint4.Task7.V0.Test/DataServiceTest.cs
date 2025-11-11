using Tyuiu.GogolevVM.Sprint4.Task7.V0.Lib;
namespace Tyuiu.GogolevVM.Sprint4.Task7.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 3;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "103050709";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
