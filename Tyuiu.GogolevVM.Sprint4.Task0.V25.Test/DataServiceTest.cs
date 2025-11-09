using Tyuiu.GogolevVM.Sprint4.Task0.V25.Lib;
namespace Tyuiu.GogolevVM.Sprint4.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 6, 3, 2, 10 };
            int res = ds.GetSumEvenArrEl(numsArray);
            int numsWaitArray = 4;
            Assert.AreEqual(numsWaitArray, res);
        }
    }
}
