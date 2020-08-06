using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class Manager : Employee
    {
        private string name;
        private long empId;
        private string position;

        public Manager(long empId, string name, string position)
        {
            this.empId = empId;
            this.name = name;
            this.position = position;
        }


        public void ShowEmployeeDetails()
        {
            Console.WriteLine(empId + " " + name);
        }
    }
}
