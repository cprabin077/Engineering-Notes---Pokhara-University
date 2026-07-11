using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    internal class Program
    {
        public void fact(int x)
        {
            int fact = 1;
            for(int i=1;i<x;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("the factorial of" + x + "is :" + fact);
        }
        static void Main(string[] args)
        {
            Program fact = new Program();
            int n, f;
            Console.WriteLine("enter the number:");
            n = Convert.ToInt32(Console.ReadLine());
            fact.fact(n);
            Console.ReadLine();
        }
    }
}
