using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_7
{
    class ScientificCalculatorImplement : ScientificCalculatorInterface
    {
        public double Exponential(double x, double y)
        {
            for (int i = 1; i < y; i++)
            {
                x = x * x;
            }
            return x;
        }

        public int Square(int x)
        {
            return x * x;
        }

        public int Qube(int x)
        {
            return x * x * x;
        }
        public double Sine(double x, double angle)
        {
            if (angle == 0)
            {
                x = 0;
            }
            if (angle == 30)
            {
                x = x * 0.5;
            }
            if (angle == 45)
            {
                x = x * 0.707;
            }
            if (angle == 90)
            {
                x = x;
            }


            return x;
        }

        public double Cos(double x, double angle)
        {
            if (angle == 0)
            {
                x = x;
            }
            if (angle == 30)
            {
                x = x * 0.8660;
            }
            if (angle == 45)
            {
                x = x * 0.7071;
            }
            if (angle == 90)
            {
                x = 0;
            }


            return x;
        }
    }
}
