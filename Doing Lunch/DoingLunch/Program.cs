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

            /*One that declares a string called mainCourse. 
Another that accepts an entry from the keyboard and stores it into 
the mainCourse variable. Use Console.ReadLine(). 
string mainCourse; 
mainCourse = Console.ReadLine(); */
            string mainCourse =Console.ReadLine();

            Console.WriteLine("How many roast potatoes?");
            string sRoasties=Console.ReadLine();
            int roastCount = Convert.ToInt32(sRoasties);

            Console.WriteLine("How many brussel sprouts?");
            string sBrussel=Console.ReadLine();
            int brusselCount = Convert.ToInt32(sBrussel);

            Console.WriteLine($“Hello, your lunch is {mainCourse} with {roastCount} roast potatoes and {brusselCount} brussel sprouts.”);

            // Put the display here!
            Console.WriteLine("Hello, your lunch is {0}",mainCourse);

            /* You will note that there are currently three prompts pre-coded with 
the lower down ones commented out. The first prompt is: 
Console.WriteLine(“What main dish would you like?”); 

5 5Add code at the very bottom of the method that prints out a 
message to the user along the lines of: 
“Hello, your lunch is xxxxx” 
Where xxxx is the mainCourse the user entered. 
 
 
23  
 
QACSFUN | Exercise Guide 
Console.WriteLine (“Hello, your lunch is “ + mainCourse); 
6 However, in view of the fact that this message is going to get 
significantly larger let’s update it immediately using the ‘special’ 
version of Console.WriteLine() 
Console.WriteLine (“Hello, your lunch is {0}“, mainCourse); 
7 Catching Numerical Information 
 
If we want a user to input numerical information we have a slight 
problem in that Console.ReadLine() treats all input as a string. 
Consequently, we need to catch the string in a similar way to the 
previous steps and then convert it to a numerical value. Let’s get the 
user to enter the number of roast potatoes they want. 
8 Uncomment the “How many roast potatoes?” prompt. Immediately 
after this statement declare a string variable called sRoasties and 
store the inputted value into it. 
9 We could clearly display this ‘string’ value in the message but later 
we will want to do arithmetic on it so we need to convert the string 
type into an int. 
So declare an int variable called roastCount and on the next line use 
the Convert.ToInt32() method in the following way: 
int roastCount; 
roastCount = Convert.ToInt32(sRoasties); 
10 Uncomment the “How many roast potatoes?” prompt. Immediately 
after this statement declare a string variable called sRoasties and 
store the inputted value into it. 
11 Repeat the previous three steps to retrieve and display information 
about the number of brussel sprouts the user would like. 
QACSFUN 
| Exercise Guide 
12 The message should now look like 
“Hello, your lunch is xxxxx with yy roast potatoes and zz brussel 
sprouts.”*/

        }

    }
}