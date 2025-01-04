using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Static
{
    internal static class Utility
    {
       
     
       // private static double pi;
        private const double pi = 3.14;
        public static double PI
        {
            get { return pi; }
           // set { pi = value; }
        }

        static Utility() //static member constructor
        {
        //    pi = 3.14;
        }
       
        public static double CmToInch(double cm)  //static member method[class method]
        {
            return cm / 2.54;
        }

        public static double ClcCircleArea(double radius) //object member method
        {
            return PI * radius * radius;
        }
       
    }
}
