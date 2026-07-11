using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionhandling_function
{
    internal class Program
    {
        public void exception(int a, int b)
        {
            int res = 0;
            try
            {
                res = a / b;
            }
            catch (DivideByZeroException e)
            { 
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine(res);
            }
        }
        static void Main(string[] args)
        {
            Program a = new Program();
            int n1, n2;
            Console.WriteLine("enter any two number:");
            n1=Convert.ToInt32(Console.ReadLine());
            n2=Convert.ToInt32(Console.ReadLine());
               a.exception(n1, n2);
            Console.ReadLine();
        }
    }
}
