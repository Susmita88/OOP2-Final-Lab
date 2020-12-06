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

            Faculty a = new Faculty("Syeda Anika Tasnim", "2001-2048-2");
            Faculty f = new Faculty("Tanvir Ahmed", "1901-1955-2");  
            

            Department c = new Department("CS", "1234");  
            c.AddFaculty(f);
            c.AddFaculty(a);
            c.ShowFaculty();
            Console.WriteLine();

            c.SearchFaculty("1901-1955-2");       
            c.RemoveFaculty(a);                  

            Console.WriteLine();
            c.ShowFaculty();                      

        }
    }
}