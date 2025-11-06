using Tyuiu.KoryakinaAE.Sprint4.Task0.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Корякина А.Э.  | ИСТНб-25-1 ";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы                                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #28                                                              *");
        Console.WriteLine("* Выполнила: Корякина Алина Эльдаяговна |  ИСТНб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* подсчитать произведение четных элементов массива.                       *");
        Console.WriteLine("* { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 }                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] numsArray = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };


        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < numsArray.Length - 1; i++)
        {
            Console.WriteLine(numsArray[i]);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Произведение всех чётных элементов массива: " + ds.GetMultEvenArrEl(numsArray));


        Console.WriteLine();
        Console.ReadKey();

    }
}