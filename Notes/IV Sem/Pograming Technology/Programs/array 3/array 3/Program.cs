using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array={ 1, 3, 5, 7, 9 }, sum = 0;
            double average = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                sum += array[i];
            }
            if(array.Length>0)
            {
                average = (double)sum/array.Length;
            }
            Console.WriteLine("Average of thr array element is{0}", average);
            Console.WriteLine("Average of the array element is{0}", average);
            Console.Writeline("sum + Average={0}", sum + average);

        }
    }
}
