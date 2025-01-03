using Demo.overloading;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;



namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 - Relational Operators Overloading
            // Complex c1 = new Complex(1, 2);
            //  Complex c2 = new Complex(2, 4);

            // Comple C1 = new Comple() { Real = 1, Imag = 2 };
            // Comple C2 = new Comple() { Real = 2, Imag = 4 };

            // if (C1 > C2)
            // {
            //     Console.WriteLine("C1 > C2");
            // }
            //else
            // {
            //     Console.WriteLine("C1 < C2");
            // }

            #endregion

            #region 2-Casting Operators Overloading
         //   object obj = 4;
         //   int y = (int)obj; //Explicit Casting
         ////  Console.WriteLine(y);

         //   Comple C1 = new Comple() { Real = 70, Imag = 2 };
         //  //int X = (int)C1;
         //  //Console.WriteLine(X); //Explicit Casting --> 70

         //   string X = (string)C1;
         //   Console.WriteLine(X); //Implicit Casting --> 70 + 2i
            //Implicit Casting ==> can be used implicit and explicit
            //Explicit Casting ==> can be used only explicit
            //Recommended to use Explicit casting
            //---------
            //Recommended to use Explicit casting
            //1] Readability
            //2] Compiler will Remind me.


            #endregion
        }
    }
}
