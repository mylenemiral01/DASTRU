using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIRAL_Two_Dimensional_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialize 2D Array
            string[,] fruits = new string[3, 3]
            {
              { "Apple", "Orange", "Banana" },
              { "Melon", "Avocado", "Grapes" },
              { "Kiwi", "Pineapple", "Papaya" }
            };
              //Display the fruits in the two-dimensional array
            Console.WriteLine("        Different kind of fruits. \n");
            Console.WriteLine("     " + "F1"+ "    \t" + "F2" + "   \t\t" + "F3");
            Console.WriteLine("  -------------------------------------");

            for (int a = 0; a < fruits.GetLength(0); a++)//Iterate through rows
            {
                Console.Write("R" + a + "| ");
                for (int s = 0; s < fruits.GetLength(1); s++)//iterate through colums
                {
                    Console.Write(fruits[a, s] + "  \t");//Print each fruit
                }
                Console.WriteLine();//New Line for each rows
            }
            Console.ReadKey();
        }
    }
}
