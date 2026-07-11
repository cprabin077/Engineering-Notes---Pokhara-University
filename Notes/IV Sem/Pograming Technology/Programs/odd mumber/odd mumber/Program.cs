using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_mumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1,i, sum = 0;
            {
                for(i=0;i<10;i++)
                {
                    sum = sum + a;
                    a = a + 2;
                }
            }
            
            Console.WriteLine("enter the sum of first ten odd number is:" + sum);
            Console.ReadLine();
        }
    }
}
