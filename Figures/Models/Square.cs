using System;
using System.Collections.Generic;
using System.Text;

namespace Figure.Models
{
    class Square : Figures
    {
        private float lengthOfSide1;

        public Square(float b)
        {
            Method(b);
        }

        public new void ToCalcPerimeter()
        {
            float res;
            lengthOfSide1 = GetlengthOfSide1();

            res = 4 * lengthOfSide1;
            Console.WriteLine("Периметр: {0}", res);
        }

        public new void ToCalcArea()
        {
            double res;
            lengthOfSide1 = GetlengthOfSide1();

            res = Math.Pow(lengthOfSide1, 2);
            Console.WriteLine("Площадь: {0}", res);
        }
    }
}
