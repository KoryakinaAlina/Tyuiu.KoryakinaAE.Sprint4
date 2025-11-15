using Tyuiu.KoryakinaAE.Sprint4.Task7.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Корякина А.Э. | ИСТНб 25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнила: Корякина Алина Эльдаяговна    | ИСТНб - 25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана строка из одноразрядных цифр \"135792468\". Преобразуйте ее в      *");
        Console.WriteLine("* матрицу 3 на 3 и подсчитайте количество четных чисел.                   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string str = "135792468";
        Console.WriteLine("Исходная строка: " + str);
        int n = 3;
        int m = 3;
        int[,] mtrx = new int[n, m];

        int index = 0;
        Console.WriteLine("\n Массив:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{str[index]} \t");
                index++;
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        var result = ds.Calculate(3, 3, str);
        Console.WriteLine("Количество четных чисел: " + result);

        Console.ReadKey();
    }
}