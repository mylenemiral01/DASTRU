using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dastru
{
     class Movies//Base Class
    { 
        //Movies Properties
        public string Title { get; set; } 
        public string Writer { get; set; }
        public string Director { get; set; }
        //Parameterized Constructor
        public Movies(string title, string writer, string director)
        {
            Title = title;
            Writer = writer;
            Director = director;
        }
        //Virtual method to display information
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: \t{Title}");
            Console.WriteLine($"Writer: {Writer}");
            Console.WriteLine($"Director: {Director}");
        }
    }
    class Hollywood : Movies//Derived Class
    {
        public string Genre { get; set; }//Additional Property
        //Parameterized Constructor
        public Hollywood(string title, string writer, string director, string genre) : base(title, writer, director)
        {
            Genre = genre;
        }
        //Ovveriding method to display information
        public override void DisplayInfo()
        {
            Console.WriteLine("=====Hollywood Movies Details=====");
            base.DisplayInfo();
            Console.WriteLine($"Genre: \t{Genre}\n");
        }
    }
    class Filipino : Movies//derived class
    {
        public int Duration { get; set; }//Additional Property
        //Parameterized Constructor
        public Filipino(string title, string writer, string director, int duration) : base(title, writer, director)
        {
            Duration = duration;
        }
        //Overriding method to display information
        public override void DisplayInfo()
        {
            Console.WriteLine("=====Filipino Movies Details=====");
            base.DisplayInfo();
            Console.WriteLine($"Duration: {Duration} minutes\n");
        }
    }
}
