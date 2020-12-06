using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Final_Lab_2
{
    class Department
    {
        ArrayList faculty;

        public string Name { get; set; }
        public string Id { get; set; }
        public Department(string name, string id)
        {
            Name = name;
            Id = id;
            faculty = new ArrayList();
        }
        public void AddFaculty(params Faculty[] faculty)
        {
            foreach (Faculty f in faculty)
            {
                this.faculty.Add(f);
            }
        }
        public void ShowFaculty()
        {
            Console.WriteLine(this.Name + "  department has following faculty : ");
            foreach (Faculty f in faculty)
            {
                f.ShowInfo();
            }
        }
        public void SearchFaculty(string fid)
        {

            foreach (Faculty f in faculty)
            {
                if (f.Id.Equals(fid))
                {
                    Console.WriteLine(f.Name + " belongs to  " + this.Name + "  dept. ");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry for this " + fid + "  any associate faculty was not found ");

                }
            }
        }
        public void RemoveFaculty(Faculty g)
        {
            Console.WriteLine(g.Name + "is removing as a faculty . . . . . . .");

            faculty.Remove(g);
            Console.WriteLine("He was removed as a faculty ");




        }
    }
}