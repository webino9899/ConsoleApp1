using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class copy_constuctor
    {
        int id;

        //parameterized constructor
        public copy_constuctor(int i)
        {
            id = i;
        }

        //copy constructor
        public copy_constuctor(copy_constuctor c)
        {
            id = c.id;
        }

        public void display()
        {
            Console.WriteLine($"ID: {id}");
        }
    }
}
