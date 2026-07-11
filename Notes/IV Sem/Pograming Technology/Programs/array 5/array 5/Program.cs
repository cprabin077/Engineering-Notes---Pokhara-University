using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("enter the size of array:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("enter the elements:");
            for(i=0;i<n;i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());

            }
            Array.Reverse(A);
            Console.WriteLine("after reversing:");
            for(i=0;i<n;i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
