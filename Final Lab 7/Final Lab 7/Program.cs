using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculatorImplement x = new BasicCalculatorImplement();
            Console.WriteLine(x.sub(3, 2));
            Console.WriteLine(x.sum(3, 2));

            ScientificCalculatorImplement y = new ScientificCalculatorImplement();
            Console.WriteLine(y.Exponential(2, 2));
            Console.WriteLine(y.Square(5));
            Console.WriteLine(y.Sine(5, 45));


        }
    }
}
