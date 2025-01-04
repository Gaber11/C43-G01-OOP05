using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Partial
{
    internal partial class Employee
    {
        public void Print()
        {
            Console.WriteLine("Hello ");
        
        }
        public partial void Hello()
        {
            Console.WriteLine("Hello from Employee");
        }
    }
}
