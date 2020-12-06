using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Final_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Faculty f = new Faculty("Tanvir Ahmed", "1901-1955-2");  // Adding Faculty
            Faculty a = new Faculty("Mir Riyanul Islam ", "190-1955-2");

            Department c = new Department("CS", "3242");  // Creating department
            c.AddFaculty(f);
            c.AddFaculty(a);
            c.ShowFaculty();
            Console.WriteLine();

            c.SearchFaculty("1901-1955-2");       // Searching a specific Faculty
            c.RemoveFaculty(a);                   // Removing a specific Faculty

            Console.WriteLine();
            c.ShowFaculty();                      // Displaying new faculty list after deletion

        }
    }
}