using Tyuiu.TiasinIA.Sprint4.Task3.V27.Lib;
namespace Tyuiu.TiasinIA.Sprint4.Task3.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Тясин И. А. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Тясин Илья Александрович | АСОиУб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 7. Подсчитайте количество   *");
            Console.WriteLine("* четных элементов во всем массиве.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            
            int[,] numsArray = new int[5, 5] { { 4, 3, 5, 5, 3 },
                                               { 6, 7, 4, 4, 3 },
                                               { 3, 3, 7, 3, 6 },
                                               { 3, 4, 3, 7, 7 },
                                               { 3, 5, 6, 3, 6 } };

            int rows = numsArray.GetUpperBound(0) + 1;
            int colums = numsArray.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{numsArray[i, j]}\t");
                }
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(numsArray);

            Console.WriteLine(" Количество всех четных элементов массива = " + result);
            Console.ReadKey();
        }
    }
}
