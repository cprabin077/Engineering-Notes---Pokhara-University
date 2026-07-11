using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] a = new int[5];
                for (i = 0; i < 5; i++)
            {
                a[i] = i;
                Console.WriteLine("" + a[i]);
            }
            Console.ReadLine();
        }
    }
}
