using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIRAL_Inserting_Nodes_to_the_Linked_List
{
    internal class Program
    {
        //Mylene I. Miral
        //IT401P
        //Inserting Nodes to the Linked List
        static void Main(string[] args)
        {
            //declare a string list
            LinkedList<string> list = new LinkedList<string>();

            //allow the user to enter a number of nodes
            Console.WriteLine("How many friends do you have? ");
            int num = int.Parse(Console.ReadLine());

            //limit the capacity of list 
            if (num < 5 ||  num > 10)
            {
                Console.WriteLine("\nPlease enter a number within the range of 5 to 10. ");
                return;
            }

            //input the first name of friends in the list
            Console.WriteLine("\nList only the first name of friends: ");
            for (int i  = 0; i < num; i++)
            {
                string name = Console.ReadLine();
                list.AddLast(name);
            }
            
            Console.WriteLine("");//spacing provided before the result
            Console.WriteLine("\tList of Result: ");
            //display the result of the list
            foreach (string name in list)
            {
                Console.Write(name + " -> ");  
            }

            Console.ReadLine();
        }
    }
}
