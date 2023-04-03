using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_ExceptionHandling
{
    public class Categorized
    {
        public void GetCategory(int age)
        {
            if (age == null || age < 1)
            {
                Console.WriteLine("Invalid age entered.");
            }
           
            if (age >= 1 && age <= 14)
            {
                Console.WriteLine("Category: Children");
            }
            else if (age >= 15 && age <= 24)
            {
                Console.WriteLine("Category: Youth");
            }
            else if (age >= 25 && age <= 64)
            {
                Console.WriteLine("Category: Adults");
            }
            else
            {
                Console.WriteLine("Category: Seniors");
            }
        }
    }
}
