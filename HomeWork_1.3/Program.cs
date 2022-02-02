using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double NUMBER_PI = 3.14; // const pi
            int r; 
            Console.Write("Dear user, enter the value of radius of circle: "); 
            r = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine($"Length is {2 * NUMBER_PI * r} "); 
            Console.WriteLine($"Area is {NUMBER_PI * Math.Pow(r, 2)}"); // use method pow for squaring
            Console.WriteLine($"Volume is {4 / 3 * NUMBER_PI * Math.Pow(r, 3)}");
            Console.WriteLine("Dear user, thanks for using my program! Have a nice day!");
            Console.ReadKey();
        }
    }
}
