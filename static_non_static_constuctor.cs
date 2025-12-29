using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class static_non_static_constuctor
    {
        //Static Constructor
        //Executed only once
        //First block of code to be executed inside a class
        //Before Main Method body start executing, this constructor will execute
        static static_non_static_constuctor()
        {
            Console.WriteLine("Static Constructor is Called");
        }
        //Non-Static Constructor
        //Executed once per object
        //When we create an instance, this constructor will execute
        public static_non_static_constuctor()
        {
            Console.WriteLine("Non-Static Constructor is Called");
        }
      
       
    }
}
