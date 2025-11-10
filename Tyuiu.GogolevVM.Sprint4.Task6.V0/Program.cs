using Tyuiu.GogolevVM.Sprint4.Task6.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        var week = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < week.Length; i++)
        {
            Console.WriteLine(week[i]);
        }

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("Количество элементов длина которых = 7:");

        int nums = ds.Calculate(week);
        Console.WriteLine(nums);
    }
}