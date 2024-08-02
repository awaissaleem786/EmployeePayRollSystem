
using EmployeePayrollSystem;

class Program

{
    public static void Main(string[] args)
    {
        PayrollSystem payrollSystem = new PayrollSystem();  
        FullTimeEmployee emp1= new FullTimeEmployee("Awais",1,3500);
        PartTimeEmployee emp2 = new PartTimeEmployee("Saleem",2,40,100);
        payrollSystem.addEmploye(emp1);
        payrollSystem.addEmploye(emp2);
        payrollSystem.displayEmployee();
        payrollSystem.removeEmploye(2);
        Console.WriteLine("After delete set one employee");
        payrollSystem.displayEmployee();
    }
}