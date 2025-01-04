using Assignment.FirstProject;
using Assignment.SecondProject;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region First Project: -Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes two parameters.Call each method in Main().

            //Maths maths = new Maths();
            //maths.Add(10, 20);
            //maths.Subtract(10, 20);
            //maths.Multiply(10, 20);
            //maths.Divide(40, 20);
            //--------------------After Modify-------------------
            //try
            //{
            //    Maths.Add(10, 20);
            //    Maths.Subtract(78, 20);
            //    Maths.Multiply(19, 20);
            //    Maths.Divide(0, 0);
            //}
            //catch (Exception ex) when (ex is InvalidOperationException
            //                        || ex is DivideByZeroException)

            //{
            //    Console.WriteLine($"Exception Cought is : { ex.Message}");
            //}


            #endregion

            #region Second Project 1.Define Class Duration To include Three Attributes Hours, Minutes and Seconds.



            #endregion

            #region Second Project 2.Override All System.Object Members (ToString, Equals, GetHasCode).

            #endregion

            #region 3.Define All Required Constructors to Produce this output:
            // Duration D1 = new Duration(1, 10, 15);
            // Console.WriteLine(D1.ToString());
            //
            // Duration D1 = new Duration(3600);
            // Console.WriteLine(D1.ToString());
            //          
            // Duration D2 = new Duration(7800);
            // Console.WriteLine(D2.ToString());
            //
            //Duration D3 = new Duration(666);
            //Console.WriteLine(D3.ToString());


            #endregion

            #region 3.Implement All required Operators overloading to enable this Code:
            Duration D1 = new Duration(1, 10, 15);
            Duration D2 = new Duration(5800);
            Duration D3 = new Duration(666);
            //  D3 = D1 + D2;
            //D3 = D1 + D2;
            //Console.WriteLine(D3);

            //  D3 = D1 + 7800;
            //D3 = D1 + 7800;
            //Console.WriteLine(D3);

            //  D3 = 666 + D3
            // D3 = 666 + D3;
            //Console.WriteLine(D3);

            //D3 = ++D1(Increase One Minute)
            //D3 = D1;   
            //Console.WriteLine(D3); //Before Increase
            //D3 = ++D1;      //(Increase One Minute)
            //Console.WriteLine(D3);

            //D3 = --D2 (Decrease One Minute)
            //D3 = D2;
            //Console.WriteLine(D3); //Before Decrease
            //D3 = --D2;      //(Decrease One Minute)
            //Console.WriteLine(D3);

            //D1= D1 -D2
            D1 = D1 - D2;
            Console.WriteLine(D1);



            #endregion
        }
    }
}
