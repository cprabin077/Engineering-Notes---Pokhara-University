using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recurcive_sum_naturial_number
{
    internal class Program
    {
        public int sum(int x)
        {
            int n = x;
            if(n==0)
            {
                return 0;
            }
            else if(n==1)
            {
                return 1;
            }
            else
            {
                return (n+sum(n-1));
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("enter how many natural number do you want to sum:");
            n=Convert.ToInt32(Console.ReadLine());

            Program c=new Program();

            Console.WriteLine("sum of first {0} natural number is {1}.",n,c.sum(n));
            Console.ReadLine();
        }
    }
}
