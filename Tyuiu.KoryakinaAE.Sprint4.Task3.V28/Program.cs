using Tyuiu.KoryakinaAE.Sprint4.Task3.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Корякина А.Э. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("* Выполнил: Корякина Алина Эльдаяговна | ИСТНб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] mas = new int[5, 5]
        {
    { 5, 4, 9, 8, 5 },
    { 4, 6, 6, 9, 9 },
    { 9, 8, 4, 8, 8 },
    { 6, 8, 6, 8, 9 },
    { 9, 4, 6, 6, 7 }
        };


        int rows = mas.GetUpperBound(0) + 1;
        int cols = mas.Length / rows;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{mas[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(mas);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}