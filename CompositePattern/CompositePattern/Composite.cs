using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class CompanyDirectory : Employee
    {
        private List<Employee> employeeList = new List<Employee>();
        public void ShowEmployeeDetails()
        {
            foreach (Employee emp in employeeList)
            {
                emp.ShowEmployeeDetails();
            }
        }

        public void AddEmployee(Employee emp)
        {
            employeeList.Add(emp);
        }

        public void RemoveEmployee(Employee emp)
        {
            employeeList.Remove(emp);
        }

    }
}
