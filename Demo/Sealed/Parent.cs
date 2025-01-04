using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealed
{
    internal class Parent
    {
        private int salary;

        public virtual int Salary
        {
            get { return salary; }
            set { salary = value + 1000; }
        }

        public virtual void Print()
        {
            Console.WriteLine("Hello I am Parent");
        }
    }
    class Child : Parent
    {
        public sealed override int Salary
        {
            get => base.Salary;
            set => base.Salary = value > 5000 ? 5000 : value;
        }
        //sealed ===> prevent the child to edit on the version
        public sealed override void Print()
        {
            Console.WriteLine("Hello I am child");
        }
    }
    sealed class  GrandChild : Child
    {
         

        public new void Print() //Masking
        {
            Console.WriteLine("Hello I am GrandChild");
        }
    }
    class Test : GrandChild
    {
        public new void Print()
        {
            Console.WriteLine("Hello I am Test");
        }
    }
}
