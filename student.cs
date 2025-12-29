using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class student
    {
        private int RegdNumber;
        private String Name;
        private int Mark1;
        private int Mark2;
        private int Mark3;
        private int TotalMarks;
        private int AvrgMarks;


        public void GetDetails()
        {
            Console.WriteLine("Enter Student Details");
            Console.WriteLine("Enter registration Number");
            RegdNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Name");    
            Name = Console.ReadLine();

            Console.WriteLine("Enter Marks of 3 subject");
            Console.WriteLine("Enter Marks of Subject 1");  
            Mark1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Marks of Subject 2");  
            Mark2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Marks of Subject 3");
            Mark3 = Convert.ToInt32(Console.ReadLine());

            TotalMarks = Mark1 + Mark2 + Mark3;
            AvrgMarks = TotalMarks / 3;

        }

        public void DisplayDetails()
        {
            // This method can be used to display student details if needed
            Console.WriteLine("Student Details:");
            Console.WriteLine($"Registration Number: {RegdNumber}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Marks1: {Mark1}");
            Console.WriteLine($"Marks2: {Mark2}");
            Console.WriteLine($"Marks3: {Mark3}");
            Console.WriteLine($"Total Marks: {TotalMarks}");
            Console.WriteLine($"Average Marks: {AvrgMarks}");
            Console.ReadKey();
 
        }
    }
}
