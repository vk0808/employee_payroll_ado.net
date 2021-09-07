using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace EmployeePayrollService
{
    class EmployeeRepo
    {
        // Variable to store Server connection
        public static string connectionString = @"Data Source=(LocalDb)\localDb;Initial Catalog=payroll_service;Integrated Security=True";
        
        SqlConnection connection = new SqlConnection(connectionString);
        

        // Method to retrieve records from dbo.table
        public void GetAllEmployee()
        {
            try
            {
                EmployeeModel employeeModel = new EmployeeModel();
                using (this.connection)
                {
                    string query = @"SELECT * FROM payroll_service.dbo.employee_payroll;";

                    SqlCommand cmd = new SqlCommand(query, this.connection);

                    this.connection.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        Console.WriteLine($"{"Name",10} {"BasicPay",10} {"Start",25} {"Gender",5} {"PhoneNumber",15} {"Address",20} {"Department",10} {"Deduction",10} {"TaxablePay",10} {"IncomeTax",10} {"NetPay",10}");
                        Console.Write($"{new string('-', 145)}\n");
                        while (dr.Read())
                        {
                            employeeModel.ID = dr.GetInt32(0);
                            employeeModel.Name = dr.GetString(1);
                            employeeModel.BasicPay = dr.GetDecimal(2);
                            employeeModel.Start = dr.GetDateTime(3);
                            employeeModel.Gender = Convert.ToChar(dr.GetString(4));
                            employeeModel.PhoneNumber = dr.GetString(5);
                            employeeModel.Address = dr.GetString(6);
                            employeeModel.Department = dr.GetString(7);
                            employeeModel.Deduction = dr.GetDecimal(8);
                            employeeModel.TaxablePay = dr.GetDecimal(8);
                            employeeModel.IncomeTax = dr.GetDecimal(9);
                            employeeModel.NetPay = dr.GetDecimal(10);
                            Console.WriteLine($"{employeeModel.Name,10} {employeeModel.BasicPay,10} {employeeModel.Start,25} {employeeModel.Gender,5} {employeeModel.PhoneNumber,15} {employeeModel.Address,20} {employeeModel.Department,10} {employeeModel.Deduction,10} {employeeModel.TaxablePay,10} {employeeModel.IncomeTax,10} {employeeModel.NetPay,10}");
                            Console.WriteLine("");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nNo data found");
                    }
                    dr.Close();
                    this.connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
