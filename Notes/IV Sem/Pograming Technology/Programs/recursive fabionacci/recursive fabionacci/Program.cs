using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursive_fabionacci
{
    internal class Program
    {
        public int fibo(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            else if(n == 1)
            {
                return 1;
            }
            else
            {
                return (fibo(n - 1) + fibo(n - 2));
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("enter the how many number do you want to print:");
            n=Convert.ToInt32(Console.ReadLine());

            Program c= new Program();
            for(int i = 0; i < n; i++)
            {
                Console.Write(c.fibo(i) + " ,");
            }
            Console.ReadLine();
        }
    }
}
