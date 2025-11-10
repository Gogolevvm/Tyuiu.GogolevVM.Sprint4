using Tyuiu.GogolevVM.Sprint4.Task2.V24.Lib;
namespace Tyuiu.GogolevVM.Sprint4.Task2.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 8,5,4,4,3,9,9,9,3,4,4,9 };

            int wait = 33;

            int res = ds.Calculate(numsArray);
            Assert.AreEqual(wait, res);
        }
    }
}
