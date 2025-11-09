using Tyuiu.GogolevVM.Sprint4.Task1.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Гоголев В.М | АСОиУБ-25-1";
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* Спринт #4                                                                                *");
        Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                                             *");
        Console.WriteLine("* Задание #1                                                                               *");
        Console.WriteLine("* Вариант #22                                                                              *");
        Console.WriteLine("* Выполнил: Гоголев Вcеволод Михайлович | АСОиУБ-25-1                                      *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный значениями с             *");
        Console.WriteLine("* клавиатуры в диапазоне от 2 до 9 подсчитать произведение нечетных элементов массива.     *");
        Console.WriteLine("* С клавиатуры:  {8, 5, 4, 4, 3, 9, 9, 9, 3, 4, 4, 9}                                            *");

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        Console.WriteLine("Введите количество массивов ");
        int len;
        len = Convert.ToInt32(Console.ReadLine());

        int[] numsArray = new int[len];

        for (int i = 0; i <= len - 1; i++)
        {
            Console.Write("Введите значение " + i + " элемента массива: ");
            numsArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("Массив: ");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.Write(numsArray[i] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        int res = ds.Calculate(numsArray);

        Console.WriteLine(res);




    }
}