using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace recurcive_function_prime
{
    internal class Program
    {
        public int prime(int num ,int i)
        {
            if(i==1)
            {
                return 1;
            }
            else if(num%i==0)
            {
                return 0;
            }
            else
            {
                return (prime(num,i - 1));
            }
        }
   

        static void Main(string[] args)
        {
            int n, res = 1;
            Console.Write("enter how many prime number do you print from 0 to:");
            n=Convert.ToInt32(Console.ReadLine());
            Program c = new Program();
            Console.WriteLine("prime number from 0 to {0}:", n);
            for(int i=2;i<=n;i++)
            {
                res = c.prime(i, i / 2);
                if(res==1)
                {
                    Console.Write(i + ",");
                }
            }
            Console.ReadLine();
        }
    }
}
