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
            EmployeeModel employee = new EmployeeModel();

            //Add record
            employee.Name = "Sukumar";
            employee.Department = "FullStack";
            employee.PhoneNumber = "1234567890";
            employee.Address = "13-Andhra Pradesh";
            employee.Gender = 'M';
            employee.BasicPay = 10000.00M;
            employee.Deduction = 1500.00M;
            employee.Start = Convert.ToDateTime("2021-09-14");

            if (repo.AddEmployee(employee))
            {
                Console.WriteLine("Records added successfully");
            }

            // Call method
            //repo.GetAllEmployee();
        }
    }
}
