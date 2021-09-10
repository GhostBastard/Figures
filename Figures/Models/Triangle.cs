using System;
using System.Collections.Generic;
using System.Text;

namespace Figure.Models
{
    class Triangle : Figures
    {
        private float lengthOfSide1;

        public Triangle(float b)
        {
            Method(b);
        }

        public new void ToCalcPerimeter()
        {
            float res;
            lengthOfSide1 = GetlengthOfSide1();

            res = 3 * lengthOfSide1;
            Console.WriteLine("Периметр: {0}", res);
        }

        public new void ToCalcArea()
        {
            double res;
            double sqrt3 = Math.Sqrt(3);
            lengthOfSide1 = GetlengthOfSide1();

            res = (sqrt3 / 4) * (Math.Pow(lengthOfSide1, 2));
            Console.WriteLine("Площадь: {0}", res);
        }
    }
}
