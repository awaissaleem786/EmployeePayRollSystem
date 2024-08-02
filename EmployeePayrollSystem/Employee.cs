using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystem
{
   abstract class Employee
    {
        private string _name;
        private int _id;

       public Employee(string name, int id)
        {
            _name = name;
            _id = id;
        }
        public string getName() 
            {
                return _name;
            }
        public int getId()
        {
            return _id;
        }
        public abstract double CalculateSalary();

        public override string ToString()
        {
            return "Employee [name="+_name+",id="+_id+", salary="+CalculateSalary()+"]";
        }
          

    }
}
