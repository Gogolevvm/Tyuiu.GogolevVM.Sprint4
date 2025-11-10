using Tyuiu.GogolevVM.Sprint4.Task2.V0.Lib;
namespace Tyuiu.GogolevVM.Sprint4.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 0, 3, 12, 11 };

            int res = ds.Calculate(numsArray);
            int wait = 23;

            Assert.AreEqual(wait, res);
        }
    }
}
