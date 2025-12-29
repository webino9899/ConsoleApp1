using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Variable_Scope
    {
        private static string HelloClass = "Hello Class";

        public void PrintMessage()
        {
            string HelloLocal = "Hello LOcal";
            Console.WriteLine(HelloLocal);
            Console.WriteLine(HelloClass);
            DoStuff();
        }

        public void DoStuff()
        {
            Console.WriteLine("A message from DoStuff: " + HelloClass);
        }

        public static void DoStuff2() 
        {
            Console.WriteLine("A message from DoStuff2: " + HelloClass);    
        }


        
    }
}
