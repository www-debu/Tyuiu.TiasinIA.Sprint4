using Tyuiu.TiasinIA.Sprint4.Task6.V16.Lib;
namespace Tyuiu.TiasinIA.Sprint4.Task6.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Тясин И. А. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнила: Тясин Илья Александрович | АСОиУб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Автомобиль\", \"Велосипед\", \"Самолет\" *");
            Console.WriteLine("*  \"Поезд\", \"Трамвай\", \"Троллейбус\", \"Метро\"                      *");
            Console.WriteLine("* выведите элементы массива, длина которых равна 8 символам .             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] dishes = { "Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро" };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < dishes.Length; i++)
            {
                Console.WriteLine(dishes[i]);
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Слова которые имеют длинну 8 символов: ");
            string[] result = ds.Calculate(dishes);
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}
