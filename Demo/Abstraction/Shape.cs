using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Demo
{
    //Shape ==> Abstract Class
    internal abstract class Shape
    {
        public decimal Dim1 { get; set; }
        public decimal Dim2 { get; set; }
        public abstract decimal Premeter { get; }
        public abstract decimal CalcArea();
        protected Shape(decimal Dim1, decimal Dim2)
        {

        }

    }
    class Rectangle : Shape
    {
        public Rectangle(decimal Dim1, decimal Dim2) : base(Dim1, Dim2)
        {

        }
        public override decimal Premeter
        {
            get { return (Dim1 + Dim2) * 2; }
        }

        public override decimal CalcArea()
        {
            return Dim1 * Dim2;
        }
    }

    class Square : Shape
    {

        public override decimal Premeter
        {
            get { return Dim1 * 4; }
        }
        public Square(decimal Dim) : base(Dim, Dim)
        {

        }
        public override decimal CalcArea()
        {
            return Dim1 * Dim1;
        }
    }
    //Rectangle ==> Concrete Class

    class Circle : Shape
    {
        public override decimal Premeter

        {
            get { return Dim1 * 2 * 3.14M; }
        }


        public Circle(decimal redius) : base(redius, redius)
        {

        }
        public override decimal CalcArea()
        {
            return Dim1 * Dim1 * 3.14M;
        }
    }
}
