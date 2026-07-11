using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter array element");
            for( int i=0;i<5;i++)
            {
                Console.WriteLine("Enter at {0} index : " , i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
           
            }
            Console.WriteLine("largest element is{0}.", a.Max());
            Console.WriteLine("smallest element is{0}.", a.Min());

            Console.ReadLine();
        }
    }
}
