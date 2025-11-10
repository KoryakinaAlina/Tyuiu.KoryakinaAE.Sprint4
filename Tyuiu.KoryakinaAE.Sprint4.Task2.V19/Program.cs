using Tyuiu.KoryakinaAE.Sprint4.Task2.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Корякина А.Э.  | ИСТНб-25-1 ";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы. (Генератор случайных чисел)                   *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #19                                                             *");
        Console.WriteLine("* Выполнила: Корякина Алина Эльдаяговна |  ИСТНб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный случайными *");
        Console.WriteLine("* в диапазоне от 4 до 9 подсчитать сумму нечетных элементов массива.       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

     
        Console.Write("Введите количество элементов массива: ");
       int len = Convert.ToInt32(Console.ReadLine());

        int[] numsArray = new int[len];

        for (int i = 0; i <= len - 1; i++)
        {
            numsArray[i] = rnd.Next(4, 9);
        }
        Console.WriteLine("Массив:");
        for (int i=0; i<= len - 1; i++)
        {
            Console.WriteLine(numsArray[i] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(numsArray);


        Console.WriteLine(res);
        Console.ReadKey();
    }
}