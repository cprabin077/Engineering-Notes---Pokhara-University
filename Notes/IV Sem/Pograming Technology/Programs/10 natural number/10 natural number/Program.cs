using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _10_natural_number
{
    internal class Program
    {
     public int sum(int x)
        {
            int sum = 0;
            for(int i=1;i<=x;i++)
            {
                sum = sum + i;
            }
            return sum;
        }
        static void main(string[]args)
        {
            Program s = new Program();
            Console.WriteLine("sum;" + s.sum(10));
            Console.ReadLine();
        }
    }
}
