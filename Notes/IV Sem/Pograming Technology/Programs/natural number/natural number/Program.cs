using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace natural_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, i;

            for(i=1;i<=10;i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("the sum of first ten natural number is:" + sum);
            Console.ReadLine();
        }
    }
}
