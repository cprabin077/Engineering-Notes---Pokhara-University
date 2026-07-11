using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace prime_or_composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, count = 0;
            Console.WriteLine("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("{0}is prime", num);
            }
            else
            {
                Console.WriteLine("{0}is composite", num);
            }
            Console.ReadLine();
        }
    }
}


