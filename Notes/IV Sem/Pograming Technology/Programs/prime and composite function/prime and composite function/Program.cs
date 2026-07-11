using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_and_composite_function
{
    internal class Program
    {public void check (int n)
        {
            int c = 0;
            for(int i=1;i<n;i++)
            {
                if(n%i==0)
                {
                    c++;
                }
            }
            if(c==2)
            {
                Console.WriteLine(n + "is prime");
            }
            else
            {
                Console.WriteLine(n + "is compsoite");
            }
        }
        static void Main(string[] args)
        {
            Program chk = new Program();
            int n;
            Console.WriteLine("enter the number:");
            n = Convert.ToInt32(Console.ReadLine());
            chk.check(n);
            Console.Readline();
        }
    }
}
