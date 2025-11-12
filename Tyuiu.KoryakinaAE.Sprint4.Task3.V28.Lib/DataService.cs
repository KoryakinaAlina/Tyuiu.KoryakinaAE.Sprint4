using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KoryakinaAE.Sprint4.Task3.V28.Lib
{
    public class DataService : ISprint4Task3V28
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;

            int res = 10;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j == 3)
                    {
                        if (matrix[i, j] < res)
                        {
                            res = matrix[i, j];
                        }
                    }
                }
            }
            return res;
        }
    }
}
