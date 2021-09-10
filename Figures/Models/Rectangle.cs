using System;
using System.Collections.Generic;
using System.Text;

namespace Figure.Models
{
    class Rectangle : Figures
    {
        private float lengthOfSide1, lengthOfSide2;

        public Rectangle(float a, float b)
        {
            Method(a, b);
        }

        public new void ToCalcPerimeter()
        {
            float res;
            lengthOfSide1 = GetlengthOfSide1();
            lengthOfSide2 = GetlengthOfSide2();
            res = (lengthOfSide1 + lengthOfSide2) * 2;
            Console.WriteLine("Периметр: {0}", res);
        }

        public new void ToCalcArea()
        {
            float res;
            lengthOfSide1 = GetlengthOfSide1();
            lengthOfSide2 = GetlengthOfSide2();
            res = lengthOfSide1 * lengthOfSide2;
            Console.WriteLine("Площадь: {0}", res);
        }
    }
}
