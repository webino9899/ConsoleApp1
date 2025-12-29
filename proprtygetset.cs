using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class proprtygetset
    {
        private int  EmpId;
        private string EmpName;

        //Property with get and set accessors
        public int empId
        {
            get { return EmpId; }
            set { EmpId = value; }
        }

        public string empName
        {
            get { return EmpName; }
            set { EmpName = value; }
        }

    }
}
