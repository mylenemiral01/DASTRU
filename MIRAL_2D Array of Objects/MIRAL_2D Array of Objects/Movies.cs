using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIRAL_2D_Array_of_Objects
{
     class Movies
    {
        public string Title { get; set; }
        public string Writer { get; set; }
        public string Director { get; set; }

        public Movies(string title, string writer, string director)
        {
            Title = title;
            Writer = writer;
            Director = director;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: \t{Title}");
            Console.WriteLine($"Writer: {Writer}");
        }
    }
    class Hollywood : Movies
    {
        public string Genre { get; set; }

        public Hollywood(string title, string writer, string director, string genre) : base(title, writer, director)
        {
            Genre = genre;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("=====Hollywood Movies Details=====");
            base.DisplayInfo();
            Console.WriteLine($"Genre: \t{Genre}\n");
        }
    }
    class Filipino : Movies
    {
        public int Duration { get; set; }

        public Filipino(string title, string writer, string director, int duration) : base(title, writer, director)
        {
            Duration = duration;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("=====Filipino Movies Details=====");
            base.DisplayInfo();
            Console.WriteLine($"Duration: {Duration} minutes\n");
        }
    }
}
