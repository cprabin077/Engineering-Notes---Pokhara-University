using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, r, c;
            Console.WriteLine("enter the order of matrix:");
            r = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            int[,] a = new int[r, c];
            int[,] b = new int[r, c];
            int[,] multi = new int[r, c];

            if(r!=c)
            {
                Console.WriteLine("matrix multiplication is not possible:");
                Console.WriteLine("that is the row and the colume(r,c)must be same.");

            }
            else
            {
                Console.writeline("enter first matrix :");
                for(i=0;i<r;i++)
                {
                    for(j=0;j<c;j++)
                    {
                        a[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("the first matrix:");
                for(i=0;i<r;i++)
                {
                    for(j=0;j<c;j++)
                    {
                        Console.Write(a[i.j] + "");
                    }
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
