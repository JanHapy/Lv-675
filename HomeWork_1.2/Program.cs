using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;       
            string name;   
            Console.Write("Dear user, what is your name? "); 
            name = Console.ReadLine(); 
            Console.Write($"Dear {name}, how old are you? "); 
            age = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine($"Your name is {name}\nYour age is {age} "); // use \n to do next line
            Console.WriteLine("Dear user, thanks for using my program! Have a great day!");
            Console.ReadKey();
        }
    }
}
