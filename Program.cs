using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the number");
            number = int.Parse(Console.ReadLine());

            if (number > 0) 
            {
                Console.WriteLine("The number is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else 
            {
                Console.WriteLine("The number is zero");
            }

           
            string evenOrodd = ( number % 2 ==0 ) ? "even" : "odd";

            Console.WriteLine("The number is " +  evenOrodd);
            Console.ReadKey();
        }
    }
}
