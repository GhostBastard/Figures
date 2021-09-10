using System;
using System.Collections.Generic;
using System.Text;

namespace Figure.Models
{
    abstract class Figures
    {
        private float lengthOfSide1;
        private float lengthOfSide2;

        public void ToCalcPerimeter()
        { }

        public void ToCalcArea()
        { }

        public void Method(float b)
        {
            lengthOfSide1 = b;
        }

        public void Method(float a, float b)
        {
            lengthOfSide1 = a;
            lengthOfSide2 = b;
        }

        protected float GetlengthOfSide1()
        {
            return lengthOfSide1;
        }
        protected float GetlengthOfSide2()
        {
            return lengthOfSide2;
        }
    }
}
