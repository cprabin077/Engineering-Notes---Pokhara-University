using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance

{ 

public class College
{
    public void CollegeName()
    {
        Console.WriteLine("Dhangadhi Engineering College");
    }
}
public class Faculty : College
{
    public void FacultyName()
    {
        Console.WriteLine("Faculty = Science and Technology ");
    }
}
public class program : Faculty
{
    public void ProgramName()
    {
        Console.WriteLine("Program = B.E Computer");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        program stu = new program();
        stu.CollegeName();
        stu.FacultyName();
        stu.ProgramName();
        Console.ReadLine();
    }
}
}