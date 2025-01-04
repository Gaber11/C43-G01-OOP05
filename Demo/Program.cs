using Demo.Casting_OperatorOverloading;
using Demo.overloading;
using Demo.Partial;
using Demo.Static;
using System.Drawing;
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

            #region 3 - Casting Operators Overloading - Mapping
            // User user = new User()
            // {
            //     Id = 1,
            //     FullName = "Gaber Ezzat",
            //     Email = "gaber@gmail.com",
            //     Password = "123co87",
            //     SecurityStamp = Guid.NewGuid(),
            // };
            //   Console.WriteLine(user.SecurityStamp);
            //Database ==>Model[user] ==> UserViewModel ==> View
            //View ==> UserViewModel ==> Model[user] ==> Database  
            //UserViewModel userViewModel = (UserViewModel)user;
            //Console.WriteLine(userViewModel.FirstName);
            //Console.WriteLine(userViewModel.LastName);
            //Console.WriteLine(userViewModel.Email);
            //UserViewModel by default convert from parent Data Type[object] to DataType
            #endregion

            #region 4 - Abstraction 

            //Rectangle rectangle = new Rectangle(10,20);

            //Console.WriteLine(rectangle.CalcArea());
            //Console.WriteLine(rectangle.Premeter);

            //Square square = new Square(5);
            //square.Dim1 = 5;
            //Console.WriteLine(square.CalcArea());
            //Console.WriteLine(square.Premeter);
            // Circle circle = new Circle(4);
            // Console.WriteLine(circle.CalcArea());
            // Console.WriteLine(circle.Premeter);

            //  Shape shape;
            //You can create reference from abstract class
            //Reference can refer to any object from any class that inherit from abstract class
            // shape = new Rectangle(10, 20);
            #endregion

            #region 5 - Static
            // Utility U1 = new Utility() { X = 10, Y = 20 };
            // Utility U2 = new Utility() { X = 30, Y = 40 };
            // //       Console.WriteLine(U1.ToString());
            // Console.WriteLine(Utility.CmToInch(20));
            // Console.WriteLine(Utility.CmToInch(20));
            // double Res = U1.ClcCircleArea(4);
            // Console.WriteLine(Res);
            //
            // Res = U2.ClcCircleArea(5);
            // Console.WriteLine(Res);

            #endregion

            #region 6 - Sealed

            #endregion

            #region 7 - Partial
            //Employee employee = new Employee() { 
            //Name = "Gaber",
            //Email = "gaber@gmail.com",
            //Age = 25,
            //Id = 1        
            
            //};
            //employee.Print();
            #endregion
        }
    }
}
