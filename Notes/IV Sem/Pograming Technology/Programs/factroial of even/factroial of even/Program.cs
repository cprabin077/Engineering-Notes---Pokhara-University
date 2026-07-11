using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace factroial_of_even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,fact=1;
            Console.WriteLine("enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=num;i++)
            {
                fact = fact *i;
            }
            Console.WriteLine("factorial" +fact);
            Console.ReadLine();
          
        }
    }
}
