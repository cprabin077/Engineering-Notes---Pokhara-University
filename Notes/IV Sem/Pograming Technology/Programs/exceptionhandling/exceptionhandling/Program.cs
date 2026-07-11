using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionhandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, res = 0;
            num1 = 30;
            num2 = 0;
            try
            {
                res = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine(res);
            }
            Console.ReadLine();
        }
    }  
}   

