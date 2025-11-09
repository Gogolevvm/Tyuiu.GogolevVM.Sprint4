using Tyuiu.GogolevVM.Sprint4.Task0.V0.Lib;
namespace Tyuiu.GogolevVM.Sprint4.Task0.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 0, 3, 0, 10 };
            int[] res = ds.Calculate(numsArray);
            int[] numsWaitArray = { 4, 1, 3, 1, 10 };
            CollectionAssert.AreEqual(numsWaitArray, res);
        }
    }
}
