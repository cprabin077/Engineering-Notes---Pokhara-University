using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_or_even_using_function
{
    internal class Program
    {
        public void sample(int n)
        {
            if(n%2!=0)
            {
                Console.WriteLine(n + "is odd number");
            }
            else
            {
                Console.WriteLine(n + "is even number");
            }
        }
        static void main(string[]arg)
        {
            Program c = new Program();
            int n;
            Console.WriteLine("enetr the number");
            n = Convert.ToInt32(Console.ReadLine());
            c.sample(n);
            Console.ReadLine();

        }
    }
}
