using Figure.Models;
using System;

namespace Figure
{
    class Program
    {
        static char InputTypeOfCalc()
        {
            char AP;
            Console.Write("Введите тип расчёта. ");
        APagain:
            Console.WriteLine("A - площадь, P - периметр");
            AP = Convert.ToChar(Console.ReadLine());
            if (AP == 'A' || AP == 'P') return AP;
            else goto APagain;
        }

        static void Main(string[] args)
        {
            char typeOfFigure;
            char AP;
            char restartProccess;
        restart:
            Console.Write("Введите тип фигуры. ");
        Input:
            Console.WriteLine("R - прямоугольник, S - квадрат, T - равносторонний треугольник.");
            typeOfFigure = Convert.ToChar(Console.ReadLine());

            switch (typeOfFigure)
            {
                case 'R':
                    AP = InputTypeOfCalc();
                    if (AP == 'P')
                    {
                        float a, b;
                        Console.WriteLine("Введите длину 1-й и 2-й сторон.");
                        a = float.Parse(Console.ReadLine());
                        b = float.Parse(Console.ReadLine());
                        Figures RP = new Rectangle(a, b);
                        Rectangle PR = RP as Rectangle;
                        PR.ToCalcPerimeter();
                    }
                    else
                    {
                        float a, b;
                        Console.WriteLine("Введите длину 1-й и 2-й сторон.");
                        a = float.Parse(Console.ReadLine());
                        b = float.Parse(Console.ReadLine());
                        Figures RA = new Rectangle(a, b);
                        Rectangle AR = RA as Rectangle;
                        AR.ToCalcArea();
                    } //площадь прямоуг. 
                    break;
                case 'S':
                    AP = InputTypeOfCalc();
                    if (AP == 'P')
                    {
                        float b;
                        Console.WriteLine("Введите длину стороны.");
                        b = float.Parse(Console.ReadLine());
                        Figures SP = new Square(b);
                        Square PS = SP as Square;
                        PS.ToCalcPerimeter();

                    }
                    else
                    {
                        float b;
                        Console.WriteLine("Введите длину стороны.");
                        b = float.Parse(Console.ReadLine());
                        Figures SA = new Square(b);
                        Square AS = SA as Square;
                        AS.ToCalcArea();
                    } //площадь квадр.
                    break;
                case 'T':
                    AP = InputTypeOfCalc();
                    if (AP == 'P')
                    {
                        float b;
                        Console.WriteLine("Введите длину стороны.");
                        b = float.Parse(Console.ReadLine());
                        Figures TP = new Triangle(b);
                        Triangle PT = TP as Triangle;
                        PT.ToCalcPerimeter();
                    }
                    else
                    {
                        float b;
                        Console.WriteLine("Введите длину стороны.");
                        b = float.Parse(Console.ReadLine());
                        Figures TP = new Triangle(b);
                        Triangle PT = TP as Triangle;
                        PT.ToCalcArea();
                    } //площадь равност. треуг.
                    break;
                default:
                    goto Input;


            }
            Console.WriteLine("Ещё раз?");
        restartProccessAgain:
            Console.WriteLine("(y/n)");
            restartProccess = Convert.ToChar(Console.ReadLine());
            if (restartProccess == 'y') { goto restart; }
            else if (restartProccess != 'y' && restartProccess != 'n')
            {
                Console.WriteLine("Введите правильное значение.");
                goto restartProccessAgain;
            }
            else { }

        }
    }
}
