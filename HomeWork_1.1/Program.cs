using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a; // Initilization variable a
            Console.WriteLine("Enter side of the squere: "); // Output message to the screne
            a = Convert.ToInt32(Console.ReadLine()); // Reading infomation from keyboard
            Console.WriteLine("Area is " + (a * a) + ", " + "Perimeter is " + (a + a)); // Output area & perimeter of the square
            Console.WriteLine("This the end, have a nice day! :D ");
            Console.ReadKey(); // This function give opportunity don't close the console window, until we press any button
        }
    }
}
