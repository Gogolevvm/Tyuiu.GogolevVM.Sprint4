using Tyuiu.GogolevVM.Sprint4.Task6.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Гоголев В.М | АСОиУБ-25-1";
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* Спринт #4                                                                                *");
        Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                                              *");
        Console.WriteLine("* Задание #6                                                                               *");
        Console.WriteLine("* Вариант #30                                                                              *");
        Console.WriteLine("* Выполнил: Гоголев Вcеволод Михайлович | АСОиУБ-25-1                                      *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
        Console.WriteLine("* Дан строковый массив данных [Береза, Дуб, Клён, Сосна, Пихта, Осина]                     *");
        Console.WriteLine("* используя класс Array, выведите элементы массива, длина которых больше 5 символов        *");
        Console.WriteLine("********************************************************************************************");


        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");


        var week = new string[] { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина"};

        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < week.Length; i++)
        {
            Console.WriteLine(week[i]);
        }

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("элементы массива, длина которых больше 5 символов: ");

        string[] nums = ds.Calculate(week);
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }


    }
}