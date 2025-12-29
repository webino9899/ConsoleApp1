using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DataTypeDemo
    {
       public void ShowDataTypes()
        {
            byte b = 65; 

            Console.WriteLine($"DECIMAL: {b}");
            Console.WriteLine($"CHARACTER: {(char)b}");
            Console.WriteLine($"byte minValue: {byte.MinValue}, byte maxValue: {byte.MaxValue}");
            Console.WriteLine($"Size of byte: {sizeof(byte)} bytes");

            sbyte sb1= 66;
            sbyte sb2= -100;

            Console.WriteLine($"sbyte1 DECIMAL: {sb1}, CHARACTER: {(char)sb1}");
            Console.WriteLine($"sbyte minValue: {sbyte.MinValue}, sbyte maxValue: {sbyte.MaxValue}");
            Console.WriteLine($"Size of sbyte:{sizeof(sbyte)} bytes");
            Console.ReadKey();



        }





    }
}
