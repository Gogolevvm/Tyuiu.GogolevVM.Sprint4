using Tyuiu.GogolevVM.Sprint4.Task1.V22.Lib;
namespace Tyuiu.GogolevVM.Sprint4.Task1.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 4, 5, 3, 12, 11, 22 };

            int res = ds.Calculate(numsArray);
            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}
