using Tyuiu.KoryakinaAE.Sprint4.Task5.V24.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int res;
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Корякина А. Э. | ИСТНб-25-1";
        Console.WriteLine("*******************************************************************************");
        Console.WriteLine("* Спринт #4                                                                   *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                            *");
        Console.WriteLine("* Задание #5                                                                  *");
        Console.WriteLine("* Вариант #24                                                                 *");
        Console.WriteLine("* Выполнила: Корякина Алина Эльдаяговна | ИСТНб-25-1                           *");
        Console.WriteLine("*******************************************************************************");
        Console.WriteLine("* Условие                                                                     *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайными *");
        Console.WriteLine("* значениями в диапазоне от -7 до 6. Найти количество положительных элементов *");
        Console.WriteLine("*******************************************************************************");
        Console.WriteLine("* Исходные данные:                                                            *");
        Console.WriteLine("*******************************************************************************");
        Console.WriteLine("Заполните массив значениями : ");
        int simple = 5;
        int donk = 5;
        int[,] matrix = new int[simple, donk];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("* Результат:                                                                  *");
        Console.WriteLine("*******************************************************************************");
        res = ds.Calculate(matrix);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}