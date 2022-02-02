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

            int a; 
            Console.WriteLine("Dear user, enter side of the square: "); 
            a = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Area is " + (a * a) + ", " + "Perimeter is " + (a + a)); 
            Console.WriteLine("Thanks for using my program! Have a good day!");
            Console.ReadKey(); 
        }
    }
}
