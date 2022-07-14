using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTheory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paidi paidi = new Paidi();
        }
    }
    abstract class Student
    {
        public string Name { get; set; } = "Unknown Name";
        public abstract int Age { get; set; }
        public void Print()
        {
            Console.WriteLine("Name is: "+ Name);
        }
        public Student()
        {
            Console.WriteLine("Eimai o constructor tis Student");
        }
    }
    class Paidi: Student
    {
        public override int Age { get; set; }
        public Paidi()
        {
            Console.WriteLine("Eimai o constructor tis Paidi");
        }
    }


}
