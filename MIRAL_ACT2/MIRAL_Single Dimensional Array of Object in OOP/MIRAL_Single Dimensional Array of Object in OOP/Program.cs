using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIRAL_Single_Dimensional_Array_of_Object_in_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movies[] movie = new Movies[5];

            movie[0] = new Hollywood("Avatar", "James Cameron", "James Cameron", "Science Fiction");
            movie[1] = new Hollywood("Spider-Man","Stan Lee", "David Cronenberg", "Action");
            movie[2] = new Hollywood("Scream", "Kevin Williamson", "Wes Craven", "Horror");
            movie[3] = new Filipino("The Missing","Carl Joseph Papa","Easy Ferrer", 90);
            movie[4] = new Filipino("One More Chance", "Vanessa R. Valdez and Carmi Raymundo", "Cathy Garcia-Molina", 115);

            foreach (Movies movies in movie)
            {
                movies.DisplayInfo();
            }

            Console.ReadKey();
        }
    }
}
