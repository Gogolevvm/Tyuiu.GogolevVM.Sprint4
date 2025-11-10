using Tyuiu.GogolevVM.Sprint4.Task6.V0.Lib;
namespace Tyuiu.GogolevVM.Sprint4.Task6.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var week = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            int res = ds.Calculate(week);
            int wait = 4;
            Assert.AreEqual(wait,res);
        }
    }
}
