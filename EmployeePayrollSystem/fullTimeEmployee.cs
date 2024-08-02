using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystem
{
    class FullTimeEmployee:Employee
    {
        private double monthSalary;

        public FullTimeEmployee(string name,int id,double monthSalary)
                  :base(name,id)
        {
            this.monthSalary = monthSalary;
        }
        public override double CalculateSalary()
        {
        return monthSalary; 
        }
    
    }
}
