using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystem
{
    class PartTimeEmployee : Employee
    {
        private int hoursWorked;

        private double hourlyRate;
        public PartTimeEmployee(string name,int id,int hoursWorked,double hourlyRate)
            :base(name, id)
        {
            this.hoursWorked = hoursWorked;
            this.hourlyRate = hourlyRate;
        }
        public override double CalculateSalary()
        {
            return hoursWorked*hourlyRate;
        }
    }
}
