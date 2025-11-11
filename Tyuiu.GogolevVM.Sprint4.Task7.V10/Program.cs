using Tyuiu.GogolevVM.Sprint4.Task7.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнил: Гоголев В.М | АСОиУБ-25-1";
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* Спринт #4                                                                                *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                  *");
        Console.WriteLine("* Задание #7                                                                               *");
        Console.WriteLine("* Вариант #10                                                                              *");
        Console.WriteLine("* Выполнил: Гоголев Вcеволод Михайлович | АСОиУБ-25-1                                      *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
        Console.WriteLine("* Дана строка из одноразрядных цифр \"695847142536\". Преобразуйте ее в матрицу 3 на 4     *");
        Console.WriteLine("* и подсчитайте сумму нечетных чисел.                                                      *");
        Console.WriteLine("*                                                                                          *");

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        int rows = 3;
        int columns = 4;
        int[,] mtrx = new int[rows, columns];

        string str = "695847142536";

        DataService ds = new DataService();
        

        int index = 0;

        Console.WriteLine("\nМассив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine($"{str[index]} \t");
                index++;
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        int res = ds.Calculate(rows, columns, str);

        Console.WriteLine("сумма нечетных чисел = " + res);
    }
}