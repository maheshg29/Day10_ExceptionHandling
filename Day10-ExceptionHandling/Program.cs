using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_ExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Day 10 Exception Handling");
            Console.WriteLine("Enter your Age");
            int age=Convert.ToInt32(Console.ReadLine());
            Categorized categorized = new Categorized();
            categorized.GetCategory(age);
        }
    }
}
