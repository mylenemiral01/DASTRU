using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dastru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mylene I. Miral
            //IT401P
            //ACTIVITY 5: Customize a User-Input Method
            Movies[,] movie = new Movies[2, 2];

            Console.WriteLine("\tEnter Hollywood movies: ");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"\nHollywood 0.{i + 1} : ");
                Console.Write("Title: ");
                string title = Console.ReadLine();
                Console.Write("Writer: ");
                string writer = Console.ReadLine();
                Console.Write("Director: ");
                string director = Console.ReadLine();
                Console.Write("Genre: ");
                string genre = Console.ReadLine();

                movie[0, i] = new Hollywood(title, writer, director, genre);
            }
                Console.WriteLine("\n\tEnter Filipino movies: \n");
                for (int i = 0; i< 2; i++)
                {
                    Console.WriteLine($"\nFilipino 0.{i + 1} : ");
                    Console.Write("Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Writer: ");
                    string writer = Console.ReadLine();
                    Console.Write("Director: ");
                    string director = Console.ReadLine();
                    Console.Write("Duration: ");
                    int duration = int.Parse (Console.ReadLine());

                    movie[1,i] = new Filipino(title,writer,director,duration);  
                }
                
            Console.Clear();
            Console.WriteLine("\t LIST OF ALL MOVIES INFORMATION \n");
            for (int row = 0; row < movie.GetLength(0); row++)
            {
                for (int col = 0; col < movie.GetLength(1); col++)
                {
                   movie[row, col].DisplayInfo();
                }
            }
            Console.ReadKey();
        }
    }
}
