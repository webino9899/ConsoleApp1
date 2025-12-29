using StaticKeyowrdDemo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // code for calling GetDetails() from student class
            //student student = new student();
            // student.GetDetails();
            //student.DisplayDetails();


            //code for scope of variable
            /*Variable_Scope printer = new Variable_Scope();
            printer.PrintMessage();*/

            //code for byte data type
            //DataTypeDemo dataTypeDemo = new DataTypeDemo();
            //dataTypeDemo.ShowDataTypes();

            //Pointer_variable pointer_Variable = new Pointer_variable();
            //pointer_Variable.getdata();



            // code for do while loop
            //Char Choise;
            //int number1, number2, result;
            //int menuoption;
            //do
            //{
            //    Console.WriteLine("Enter The Number1");
            //    number1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter the number2");
            //    number2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Press 1 for Addition / 2 for Substraction / 3 for Multification / 4 for Division");
            //    menuoption = Convert.ToInt32(Console.ReadLine());

            //    switch (menuoption)
            //    {
            //        case 1:
            //            Console.WriteLine($"Sum Is {number1 + number2}");
            //            break;

            //        case 2:
            //            Console.WriteLine($"Sub Is {number1 - number2}");
            //            break;

            //        case 3:
            //            Console.WriteLine($"Mul Is {number1 * number2}");
            //            break;

            //        case 4:
            //            Console.WriteLine($"Div Is {number1 / number2}");
            //            break;
            //    }

            //    Console.WriteLine("Please Enter Y to Continue");
            //    Choise = Convert.ToChar(Console.ReadLine());
            //} while (char.ToUpper(Choise) == 'Y');



            //code for for loop perfect number
            //int n, i, sum = 0 ;
            //Console.WriteLine("Enter The Number");
            //n = Convert.ToInt32(Console.ReadLine());

            //for (i = 1; i < n; i++)
            //{
            //    if(n % i == 0)
            //    {
            //        sum = sum + i;
            //    }

            //}
            //if (sum == n)
            //{
            //    Console.WriteLine("The Number is Perfect Number");
            //}
            //else
            //{
            //    Console.WriteLine("The Number is Not Perfect Number");
            //}

            //code for command line arguements
            //Console.WriteLine($"First Command LIne Arguement {args[0]}");
            //Console.WriteLine($"Seconf Command LIne Arguement {args[1]}");
            //Console.WriteLine($"Third Command LIne Arguement {args[2]}");

            ////convert into integer type
            //int argument1 = Convert.ToInt32(args[0]);
            //Console.WriteLine("Argument in Integer Form : " + argument1);
            ////convert into double type
            //double argument2 = Convert.ToDouble(args[1]);
            //Console.WriteLine("Argument in Double Form : " + argument2);

            //ststic and non static constructor call
            //Program Execution will start from the Main method
            //But before executing the Main method body, it will
            //execute the static constructor
            //Console.WriteLine("Main Method Execution Start");
            //static_non_static_constuctor obj1 = new static_non_static_constuctor();
            //static_non_static_constuctor obj2 = new static_non_static_constuctor();
            //Console.WriteLine("Main Method Execution End");
            //Console.WriteLine("Main Method Execution End");
            //Console.ReadLine();



            //proprtygetset proprtygetset = new proprtygetset();
            ////WE CANNOT ACCESS THE PRIVATE DATA MEMBERS
            //// SO, USING PUBLIC PROPERTIES(SET ACCESSOR) WE ARE SETTING
            ////THE VALUES OF PRIVATE DATA MEMBERS
            //proprtygetset.empId = 101;
            //proprtygetset.empName = "Pranaya";

            //// USING PUBLIC PROPERTIES(GET ACCESSOR) WE ARE GETTING
            //// //THE VALUES OF PRIVATE DATA MEMBERS
            //Console.WriteLine($"Employee Details:{proprtygetset.empId}");
            //Console.WriteLine($"Employee Details:{proprtygetset.empName}");


            ////Assesor in C# get set
            //Employee emp = new Employee();
            //emp.FirstName = "Pranaya";
            //emp.LastName = "Rout";
            //Console.WriteLine(emp.ToString());
            //Console.ReadKey();



            ////Boxing and unboxing
            //Stopwatch stopwatch1 = new Stopwatch();
            //stopwatch1.Start();
            //for (int i = 1; i <= 1000000; i++)
            //{
            //    //Boxing();
            //    Unboxing(); 
            //}

            //stopwatch1.Stop();
            //Console.WriteLine($"Boxing took: {stopwatch1.ElapsedMilliseconds} MS");
            //Stopwatch stopwatch2 = new Stopwatch();
            //stopwatch2.Start();
            //for (int i = 1; i <= 1000000; i++)
            //{
            //    WithoutBoxing();
            //}
            //stopwatch2.Stop();
            //Console.WriteLine($"Without Boxing took: {stopwatch2.ElapsedMilliseconds} MS");



            ////Default Constructor
            //Default_Constrctor d1 = new Default_Constrctor();

            //Console.WriteLine($"Default Value of int: {d1.id}");
            //Console.WriteLine($"Default Value of bool: {d1.status}");
            //Console.WriteLine($"Default Value of string: {d1.name}");

            //Parameterized Constructor
            //parameterized_Constuctor_cs p1 = new parameterized_Constuctor_cs(101, "Pranaya", true);
            //parameterized_Constuctor_cs p2 = new parameterized_Constuctor_cs(102, "Meera", false);
            //parameterized_Constuctor_cs p3 = new parameterized_Constuctor_cs(103, "Ramesh", true);


            ////Copy Constructor
            //copy_constuctor c1 = new copy_constuctor(101);
            //c1.display();
            //copy_constuctor c2 = new copy_constuctor(c1); //copying c1 object data to c2 object
            //c2.display();

            //try
            //{ 
            //    //Encapsulation
            //     Encapsulation encap = new Encapsulation();
            //    //You cannot access the Private Variable
            //    //bank.balance; //Compile Time Error
            //    encap.SetBalance(5000); //Setting balance using Setter method
            //    Console.WriteLine($"Balance is: {encap.GetBalance()}"); //Getting balance using Getter method
            //    encap.SetBalance(-12);
            //    Console.WriteLine($"Balance is: {encap.GetBalance()}"); //Getting balance using Getter method
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //Console.WriteLine("Transaction doing SBI Bank");
            //IBank sbi = BankFactory.GetBankObject("SBI");
            //sbi.ValidateCard();
            //sbi.WithdrawMoney();
            //sbi.CheckBalanace();
            //sbi.BankTransfer();
            //sbi.MiniStatement();
            //Console.WriteLine("\nTransaction doing AXIX Bank");
            //IBank AXIX = BankFactory.GetBankObject("AXIX");
            //AXIX.ValidateCard();
            //AXIX.WithdrawMoney();
            //AXIX.CheckBalanace();
            //AXIX.BankTransfer();
            // AXIX.MiniStatement();


            ////Multilevel Interitance
            //Cuboid cuboid = new Cuboid(10, 20, 30);
            //Console.WriteLine($"Volume is : {cuboid.Volume()}");
            //Console.WriteLine($"Area is : {cuboid.Area()}");
            //Console.WriteLine($"Perimeter is : {cuboid.Perimeter()}");


           // // Method Overriding
           // Employee emp1 = new Developer
           //{
           //    Id = 1001,
           //    Name = "Ramesh",
           //    Salary = 500000,
           //    Designation = "Developer"
           //};

           // double bonus = emp1.CalculateBonus(emp1.Salary);

           // Console.WriteLine($"Name: {emp1.Name}, Designation: {emp1.Designation}, Salary: {emp1.Salary}, Bonus:{bonus}");
           // Console.WriteLine();

           // Employee emp2 = new Manager
           // {
           //     Id = 1002,
           //     Name = "Suresh",
           //     Salary = 800000,
           //     Designation = "Manager"
           // };
           // double bonus2 = emp2.CalculateBonus(emp2.Salary);
           // Console.WriteLine($"Name: {emp2.Name}, Designation: {emp2.Designation}, Salary: {emp2.Salary}, Bonus:{bonus2}");
           // Console.WriteLine();


           // Employee emp3 = new admin
           // {
           //     Id = 1003,
           //     Name = "Mahesh",
           //     Salary = 600000,
           //     Designation = "Employee"
           // };
           // double bonus3 = emp3.CalculateBonus(emp3.Salary);
           // Console.WriteLine($"Name: {emp3.Name}, Designation: {emp3.Designation}, Salary: {emp3.Salary}, Bonus:{bonus3}");
           // Console.WriteLine();



            Console.ReadLine();



        }
        //With Boxing
        //public static void Boxing()
        //{
        //    int i = 100;
        //    object j = i; //Boxing
        //}
        //Without Boxing
        //public static void WithoutBoxing()
        //{
        //    int i = 100;
        //    int j = i; //No Boxing and No Unboxing
        //}

        //With Unboxing
        //public static void Unboxing()
        //{
        //    object j = 100;
        //    int i = (int)j; //Unboxing
        //}














        //public class Employee
        //{
        //    public string FirstName;
        //    public string LastName;

        //    //Overriding the Virtual ToString method of Object class
        //    //Overriding the Virtual method using override modifier
        //    public override string ToString()
        //    {
        //        return FirstName + ", " + LastName;
        //    }
        //}
    }
}
