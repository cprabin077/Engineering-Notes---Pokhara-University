using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, temp;
            Console.WriteLine("Enter any two numbers: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping: ");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After swapping: ");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            Console.ReadLine();
        }
    }
} 
