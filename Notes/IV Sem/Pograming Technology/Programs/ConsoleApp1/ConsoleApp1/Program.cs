using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the number");
            n=Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
              Console.WriteLine("even number");
            }
            else
            {
                Console.WriteLine("odd number");
            }
            Console.ReadLine();
    }
}
