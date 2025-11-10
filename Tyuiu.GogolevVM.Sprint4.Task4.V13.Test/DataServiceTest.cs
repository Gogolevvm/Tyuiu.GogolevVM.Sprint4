using Tyuiu.GogolevVM.Sprint4.Task4.V13.Lib;
namespace Tyuiu.GogolevVM.Sprint4.Task4.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[3, 3] { { 0, 0, 1 },
                                          { 1 ,0, 1 },
                                          { 1, 1, 0 } };
            int res = ds.Calculate(mas2);
            int wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}
