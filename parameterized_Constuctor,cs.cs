using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class parameterized_Constuctor_cs
    {
        public parameterized_Constuctor_cs(int id, string name, bool status)
        {
            Console.WriteLine($"Parameterized Constructor is Called ID: {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Status: {status}");
        }
    }
}
