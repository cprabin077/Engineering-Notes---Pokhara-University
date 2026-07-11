using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, rev = 0, rem, temp;

            Console.WriteLine("enter the number:");
            n = Convert.ToInt32(Console.ReadLine());

            temp = n;
            while(n!=0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            if(temp==rev)
            {
                Console.WriteLine(temp.ToString()+ " is palindrom");
            }
            else
            {
                Console.WriteLine(temp.ToString()+ " is not palindrom");
            }
            Console.ReadLine();
        }
    }
}
