using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TiasinIA.Sprint4.Task5.V22.Lib
{
    public class DataService : ISprint4Task5V22
    {
        public int Calculate(int[,] matrix)
        {
            int colums = matrix.GetUpperBound(0) + 1;
            int rows = matrix.Length / colums;


            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
