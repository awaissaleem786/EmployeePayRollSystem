using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystem
{
    class PayrollSystem
    {

        LinkedList<Employee> employeeList;


        public PayrollSystem()
        {
            employeeList = new LinkedList<Employee>();
        }

        public void addEmploye(Employee employee)
        {
            employeeList.AddLast(employee);
        }
        public void removeEmploye(int id)
        {
            Employee employeeRemove = null;
            foreach (Employee emp in employeeList)
            {
                if (emp.getId() == id)
                {
                    employeeRemove = emp;
                    break;
                }
            }
            if (employeeRemove != null)
            {
                employeeList.Remove(employeeRemove);
            }

        }
        public void displayEmployee()
        {
            foreach (Employee emp in employeeList)
            {
                Console.WriteLine(emp);
            }
        }

          
    }
    
}
