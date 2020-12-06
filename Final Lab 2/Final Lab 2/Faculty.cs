using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_2
{
    class Faculty
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public Faculty(string name, string id)
        {
            Name = name;
            Id = id;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Teacher's Name  :" + Name);
            Console.WriteLine("Teacher's ID  :" + Id);

        }
    }
}
