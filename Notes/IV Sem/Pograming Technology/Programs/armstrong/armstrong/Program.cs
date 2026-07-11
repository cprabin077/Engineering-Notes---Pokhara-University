using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0, rem, temp;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while(n!=0)
            {
                rem = n % 10;
                rem = sum + rem * rem * rem ;
                n = n % 10;
            }
            if(sum==n)
            {
                Console.WriteLine(temp + "is armstrom");
            }
            else
            {
                Console.WriteLine(temp + "is not armstrom");

            }
            Console.ReadLine();
        }
    }
}
