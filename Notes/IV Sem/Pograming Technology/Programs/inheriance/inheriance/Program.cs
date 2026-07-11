using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheriance
{
    public class animal
    {
        public void bark()

        {
            Console.WriteLine("cat barks");

            
        }
    }
    public class cat: animal
    {
        public void run()
        {
            Console.WriteLine("cat run");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            cat a= new cat();
            
            a.run();
            a.bark();
            Console.ReadLine();
            

        }
    }
}
