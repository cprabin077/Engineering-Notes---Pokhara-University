using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace series_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a = 0, b = 1, c;
            Console.WriteLine("enter the number of terms:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0}\t{0}\t", a, b);
            for(int i=1;i<=n-2;i++)
            {
                c = a + b;
                Console.Write("{0}\t", c);
                a = b;
                b = c;
            }
            Console.ReadLine();
        }
    }
}
