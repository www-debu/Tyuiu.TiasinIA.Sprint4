﻿using Tyuiu.TiasinIA.Sprint4.Task1.V9.Lib;
namespace Tyuiu.TiasinIA.Sprint4.Task1.V9
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Тясин Илья Александрович | АСОиУб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 8 подсчитать произведение   *");
            Console.WriteLine("* четных элементов массива: 6, 3, 3, 7, 7, 7, 7, 3, 3, 6, 4, 4, 8         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = { 6, 3, 3, 7, 7, 7, 7, 3, 3, 6, 4, 4, 8 };

            Console.WriteLine("Исходныйы массив = " + numsArray);
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine(numsArray[i]);
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(numsArray);

            Console.WriteLine("Произведение всех четных элементов массива = " + result);
            Console.ReadKey();
        }
    }
}
