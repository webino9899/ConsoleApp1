using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Method_Overriding
    {
    }

    class Employee
    {
        public int   Id { get; set; }
        public String Name { get; set; }
        public  String Designation { get; set; }
        public double Salary { get; set; }


        public virtual double CalculateBonus( double salary)
        {
                 return 50000;
        }   
    }

    class Developer : Employee
    {
       
        public override double CalculateBonus(double salary)
        {
            Double base_salary = base.CalculateBonus(salary);
            Double Calculated_salary = salary * .20;
            if (base_salary >= Calculated_salary)
            {
                return base_salary;
            }
            else
            { 
                return Calculated_salary; }
           
        }   

    }

    class Manager : Employee
    {
        public override double CalculateBonus( double salary)
        {
            Double base_salary = base.CalculateBonus(salary);
            Double Calculated_salary = salary * .30;
            if (base_salary >= Calculated_salary)
            {
                return base_salary;
            }
            else
            {
                return Calculated_salary;
            }
        }
    }

    class admin : Employee
    {
        // No override, uses base class implementation
    }




}
