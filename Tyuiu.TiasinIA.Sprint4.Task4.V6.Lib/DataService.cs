using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TiasinIA.Sprint4.Task4.V6.Lib
{
    public class DataService : ISprint4Task4V6
    {
        public int[,] Calculate(int[,] matrix)
        {
            int colums = matrix.GetUpperBound(0) + 1;
            int rows = matrix.Length / colums;


            

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i,j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}
