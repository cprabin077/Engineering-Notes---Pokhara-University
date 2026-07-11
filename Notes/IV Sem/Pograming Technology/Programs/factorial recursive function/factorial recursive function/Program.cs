using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_recursive_function
{
    internal class Program
    {
        public int fact(int x)
        {
            int n = x;
            if(n==0||n==1)
            {
                return 1;
            }
            else
            {
                return (n * fact(n - 1));
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("enter any number");
            n = Convert.ToInt32(Console.ReadLine());
            
            Program c=new Program();
            Console.WriteLine("factorial of {0} is {1}",n,c.fact(n));

            Console.ReadLine();
        }
    }
}
