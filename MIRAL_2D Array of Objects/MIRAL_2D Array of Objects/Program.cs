using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIRAL_2D_Array_of_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movies[,] Movies = new Movies[2, 2];

            Movies[0,0] = new Hollywood("Avatar", "James Cameron", "James Cameron", "Science Fiction");
            Movies[0,1] = new Hollywood("Spider-Man", "Stan Lee", "David Cronenberg", "Action");

            Movies[1,0] = new Filipino("The Missing", "Carl Joseph Papa", "Easy Ferrer", 90);
            Movies[1,1] = new Filipino("One More Chance", "Vanessa R. Valdez and Carmi Raymundo", "Cathy Garcia-Molina", 115);

            for (int i = 0; i < Movies.GetLength(0); i++)
            {
                for (int j = 0; j < Movies.GetLength(1); j++)
                {
                    Movies[i, j].DisplayInfo();
                }
            }

            Console.ReadKey();
        }
    }
}
