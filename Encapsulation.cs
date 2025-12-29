using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Encapsulation
    {
        //Hiding class data by declaring the variable as private
        private int balance;

        //Creating public Setter and Getter methods
        //Public Getter Method
        //This method is used to return the data stored in the balance variable
        public double GetBalance()
        {
            //add validation logic if needed
            return balance;
        }

        //Public Setter Method
        //This method is used to stored the data  in the balance variable
        public void SetBalance(int balance)
        {
            //add validation logic if needed
            if (balance >= 0)
            {
                this.balance = balance;
            }
            else
            {
                throw new Exception("Invalid Amount. Balance cannot be negative.");
            }
        }


    }
}
