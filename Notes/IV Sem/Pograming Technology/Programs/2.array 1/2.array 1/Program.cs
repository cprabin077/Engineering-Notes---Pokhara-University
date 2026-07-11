using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.array_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  row, col;
            int 
            Console.WriteLine("enter the row matrix:");
            row= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the col matrix:");
            col= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter element for {0}*{1] matrix :", row , col);
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    Console.WriteLine("enter the element for positions A[{0},{1}]:", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("your {0}*{1} matrix is:", row, col);
            Console.WriteLine();
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    Console.WriteLine(a[i, j] + " ");
                }
                Console.WriteLine();
            }


            

        }
    }
}
