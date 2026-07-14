using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DoingLunch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What main dish would you like?");


            string mainCourse =Console.ReadLine();

            Console.WriteLine("How many roast potatoes?");
            string sRoasties=Console.ReadLine();
            int roastCount = Convert.ToInt32(sRoasties);

            Console.WriteLine("How many brussel sprouts?");
            string sBrussel=Console.ReadLine();
            int brusselCount = Convert.ToInt32(sBrussel);

            Console.WriteLine($"Hello, your lunch is {mainCourse} with {roastCount} roast potatoes and {brusselCount} brussel sprouts”);

            // Put the display here!
            Console.WriteLine("Hello, your lunch is {0}",mainCourse);

        }

    }
}