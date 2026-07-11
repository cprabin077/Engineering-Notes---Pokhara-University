using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 7, 2, 9, 4, 1 };
            Array.Sort(array);
            Console.WriteLine("Array sorted in ascendimg order:");
            for(int i=0;i<array.Length;i++)
            {
                Console.Write("{0}", array[i]);
                
            }
            Console.WriteLine();
            Array.Reverse(array);
            Console.WriteLine("array sorted inascending order:");
            for(int i=0;i<array.Length;i++)
            {
                Console.Write("{0}", array[i]);
            }
            Console.WriteLine();
        }
    }
}
