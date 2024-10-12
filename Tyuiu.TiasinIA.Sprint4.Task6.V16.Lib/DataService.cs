using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TiasinIA.Sprint4.Task6.V16.Lib
{
    public class DataService : ISprint4Task6V16
    {
        public string[] Calculate(string[] array)
        {
            int count = 0;
            foreach (string dish in array)
            {
                if (dish.Length == 7)
                {
                    count++;
                }
            }


            string[] filteredDishes = new string[count];
            int index = 0;


            foreach (string dish in array)
            {
                if (dish.Length == 7 )
                {
                    filteredDishes[index] = dish;
                    index++;
                }
            }

            return filteredDishes;
        }
    }
}
