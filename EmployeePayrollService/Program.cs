using System;

namespace EmployeePayrollService
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to Employee Payroll\n");

            // Object instantiation
            EmployeeRepo repo = new EmployeeRepo();
            
            // Call method
            repo.GetAllEmployee();
        }
    }
}
