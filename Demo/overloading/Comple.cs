using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.overloading
{
    public class Comple
    {
        public int Real { get; set; }
        public int Imag { get; set; }
      
        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
        public static Comple operator +(Comple Left, Comple Right)
        {
            return new Comple()
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) + (Right?.Imag ?? 0)
            };
            //left?.Real
            //Left !=null? Left.Real:null
        }
        public static Comple operator -(Comple Left, Comple Right)
        {
            return new Comple()
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) - (Right?.Imag ?? 0)
            };
            //left?.Real
            //Left !=null? Left.Real:null
        }

        public static bool operator>(Comple Left ,Comple Right)
        {
            if (Left.Real == Right.Real)
                return Left.Imag > Right.Imag;
            else
                return Left.Real > Right.Real;
        }
        public static bool operator <(Comple Left , Comple Right)
        {
            if (Left.Real == Right.Real)
                return Left.Imag < Right.Imag;
            else
                return Left.Real < Right.Real;
        }
        
        public static explicit operator int(Comple C1)
        {
            return C1?.Real??0;
        }
        public static implicit operator string(Comple C1)
        {
            return C1?.ToString()?? String.Empty;
        }

    }
}