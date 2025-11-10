using Tyuiu.GogolevVM.Sprint4.Task5.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();
        Console.Title = "Спринт #4 | Выполнил: Гоголев В.М | АСОиУБ-25-1";
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* Спринт #4                                                                                *");
        Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                                     *");
        Console.WriteLine("* Задание #4                                                                               *");
        Console.WriteLine("* Вариант #13                                                                              *");
        Console.WriteLine("* Выполнил: Гоголев Вcеволод Михайлович | АСОиУБ-25-1                                      *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный слечайыми значениями    *");
        Console.WriteLine("* клавиатуры в диапазоне от -4 до 4. Заменить положительные элементы на 1.                 *");
        Console.WriteLine("********************************************************************************************");

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        Console.WriteLine("Введите количество строк в массиве");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов в массиве");
        int columns = Convert.ToInt32(Console.ReadLine());

        int[,] mtrx = new int[rows, columns];
        Console.WriteLine("********************************************************************************************");

        Console.WriteLine("\nМассив");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                mtrx[i,j] = rnd.Next(-4,4);
            }
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mtrx[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");
        int[,] res = ds.Calculate(mtrx);
        Console.WriteLine(" Итоговый массив");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{res[i, j]} \t");
            }
            Console.WriteLine();
        }




    }
}