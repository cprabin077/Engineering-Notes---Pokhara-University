using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count=0;
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 1; j <= i; j++)
                { 
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.Write("{0}\t", i);
                }
                count = 0;
            }
            Console.ReadLine();
        }
          
        }
    }

