using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int rollno;
            int adsa;
            {
                Console.WriteLine("enter the name:");
                name = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter roll:");
                rollno = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your Name is " + name + '.' + "Roll no: " + rollno);
            Console.ReadLine();
        }
    }
}
