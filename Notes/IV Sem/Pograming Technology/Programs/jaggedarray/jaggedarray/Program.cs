using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[2][];
            a[0] = new int[] { 1, 2, 3, 4 };
            a[1] = new int[] { 1, 2 };
                int i, j;
            for(i=0;i<a.Length;i++)
            {
                for (j = 0; j < a[i].Length;j++)
                {
                    Console.WriteLine(a[i][j] + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
