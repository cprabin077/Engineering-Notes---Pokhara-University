using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
