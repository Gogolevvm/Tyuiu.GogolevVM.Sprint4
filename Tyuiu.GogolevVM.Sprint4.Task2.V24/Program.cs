using Tyuiu.GogolevVM.Sprint4.Task2.V24.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();
        Console.Title = "Спринт #4 | Выполнил: Гоголев В.М | АСОиУБ-25-1";
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* Спринт #4                                                                                *");
        Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                                     *");
        Console.WriteLine("* Задание #2                                                                               *");
        Console.WriteLine("* Вариант #24                                                                              *");
        Console.WriteLine("* Выполнил: Гоголев Вcеволод Михайлович | АСОиУБ-25-1                                      *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов случайными заполненный статическими  *");
        Console.WriteLine("* значениями в диапазоне от 4 до 9 подсчитать сумму нечетных элементов массива.            *");
        Console.WriteLine("*                                                                                          *");

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        int len;
        Console.WriteLine("Введите количество элементов массива");
        len = Convert.ToInt32(Console.ReadLine());

        int[] numsArray = new int[len];

        for (int i = 0; i < numsArray.Length; i++)
        {
            numsArray[i] = rnd.Next(4,9);
        }

        Console.WriteLine("Массив: ");
        for (int i = 0; i < len; i++)
        {
            Console.Write(numsArray[i] + "\t");
        }

        Console.WriteLine();
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        int res = ds.Calculate(numsArray);

        Console.WriteLine("Сумма нечетных элементов  = " + res);

    }
}