using Tyuiu.KoryakinaAE.Sprint4.Task4.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Корякина А. Э. | ИСТНб-25-1";
        Console.WriteLine("*******************************************************************************");
        Console.WriteLine("* Тема: Двумерные массивы (ввод c клавиатуры)                                 *");
        Console.WriteLine("* Задание #4                                                                  *");
        Console.WriteLine("* Вариант #14                                                                 *");
        Console.WriteLine("* Выполнила: Корякина Алина Эльдаяговна | ИСТНб-25-1                        *");
        Console.WriteLine("*******************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                    *");
        Console.WriteLine("* Заменить все нечетные элементы массива на ноль                              *");
        Console.WriteLine("*                                                                             *");
        Console.WriteLine("*                                                                             *");
        Console.WriteLine("*******************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
        Console.WriteLine("*******************************************************************************");

        int rows;
        Console.WriteLine("Введите количество cтрок в массиве: ");
        rows = Convert.ToInt32(Console.ReadLine());

        int columns;
        Console.WriteLine("Введите количество столбцов в массиве: ");
        columns = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("*******************************************************************************");
        int[,] matrix = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine($"Введите {i},{j} элемент массива: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine();
        Console.WriteLine("Массив: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine($"{matrix[i, j]} \t ");
            }
        }
        Console.WriteLine();


        Console.WriteLine("*******************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
        Console.WriteLine("*******************************************************************************");

        matrix = ds.Calculate(matrix);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine($"{matrix[i, j]} \t ");
            }
        }

        Console.ReadKey();
    }
}