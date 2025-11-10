using Tyuiu.GogolevVM.Sprint4.Task4.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Гоголев В.М | АСОиУБ-25-1";
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* Спринт #4                                                                                *");
        Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                                             *");
        Console.WriteLine("* Задание #4                                                                               *");
        Console.WriteLine("* Вариант #13                                                                              *");
        Console.WriteLine("* Выполнил: Гоголев Вcеволод Михайлович | АСОиУБ-25-1                                      *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значениями с            *");
        Console.WriteLine("* клавиатуры в диапазоне от 3 до 7. Найдите сумму четных элементов массива.                *");
        Console.WriteLine("* {6, 3, 5, 7, 5}, {3, 5, 7, 4, 5}, {5, 6, 4, 5, 4}, {7, 4, 7, 3, 3}, {4, 6, 5, 5, 6}      *");
  



        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");


        Console.Write("Введите количество строк в массиве: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество столбцов в массиве: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        int[,] mtrx = new int[rows, columns];

        Console.WriteLine("********************************************************************************************");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Введите {i},{j} элемент массива: ");
                mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("\nМассив");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mtrx[i, j]} \t");
            }
        }

        Console.WriteLine();
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");
        int res = ds.Calculate(mtrx);

        Console.WriteLine("Сумма четных элементов = " + res);

    }
}