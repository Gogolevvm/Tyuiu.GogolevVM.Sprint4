using Tyuiu.GogolevVM.Sprint4.Task6.V30.Lib;
namespace Tyuiu.GogolevVM.Sprint4.Task6.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] week = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            string[] res = ds.Calculate(week);
            string[] wait = new string[] {  "Понедельник", "Вторник",  "Четверг", "Пятница", "Суббота", "Воскресенье" };
            CollectionAssert.AreEqual(wait,res);
        
            
        }
    }
}
