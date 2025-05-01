using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.FirstProject
{

    internal static class Maths
    {

       
        
         public static void Add(int a, int b)
        {
            

            Console.WriteLine($"Addition of {a} + {b} = {a + b}");
        }

        public static void Subtract(int a, int b)
        {

            Console.WriteLine($"Subtraction of {a} - {b} = {a - b}");

        }

        public static void Multiply(int a, int b)
        {
            Console.WriteLine($"Multiplication of {a} × {b} = {a * b}");

        }

        public static void Divide(double a, double b)
        {
            Console.WriteLine($"Division of {a} ÷ {b} = {a / b}");

        }
    }
       
}
       
    

