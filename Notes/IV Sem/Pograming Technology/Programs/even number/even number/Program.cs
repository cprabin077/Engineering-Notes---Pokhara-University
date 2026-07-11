using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, a = 2, sum = 0;

            for(i=0;i<10;i++)
            {
                sum = sum + a;
                a = a + 2;
            }
            Console.WriteLine("enter the first ten even number:" + sum);
            Console.ReadLine();

        }
           
    }
}
