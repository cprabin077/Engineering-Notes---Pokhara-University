using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratices
{ 
    public class box
    {
        public int length;
        public int breadth;
        public int height;

        public void set_l (int l)
        {
            length = l;
        }
        public void set_b(int b)
        {
            breadth = b;
        }
        public void set_h(int h)
        {
            height = h;
        }
        public int get_volume()
        {
            return (length * breadth * height);

        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("enter the object:");
            size=Convert.ToInt32(Console.ReadLine());
            box[]b= new box[size];
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("enter the length{0}",i+1);
                b[i] = new box();
                Console.WriteLine("enter the breadth{0}", i + 1);
                b[i]= new box();
                Console.WriteLine("enter the heigth{0}",i+1);
                b[i]=new box();
                Console.WriteLine("area of box {0} is {1}", i + 1, b[i].get_area());
                Console.WriteLine("volume of box {0] is {1}", i + 1, b[i].get_volume());
            }
            Console.ReadLine();
           
        }
    }
}
