using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Employee_PayRoll_Service_1
{
    public class EmployeeRepo
    {
        public static string connectionString = "Data Source=DESKTOP-CL8506B;Initial Catalog=payroll_service;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public bool GetAllEmployee()
        {
            try
            {
                EmployeeModel model = new EmployeeModel();
                string query = "SELECT * FROM employee_payroll;";
                connection.Open();

                using (connection)
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        Console.WriteLine("Employee Details........");
                        Console.WriteLine("ID\tName\tSalary\tDate\tNumber\tAddress\tDEPT\tBasic_pay\tDeduction\tTax\tIncome\tNetPay");
                        while (dr.Read())
                        {
                            model.Id = dr.GetInt32(0);
                            model.Name = dr.GetString(1);
                            model.Salary = dr.GetFloat(2);
                            model.StartDate = dr.GetDateTime(3);
                            model.Phone_Number = dr.GetString(4);
                            model.Emp_Address = dr.GetString(5);
                            model.Emp_DEPT = dr.GetString(6);
                            model.Basic_Pay = dr.GetString(7);
                            model.Deduction = dr.GetString(8);
                            model.Taxable_Pay = dr.GetFloat(9);
                            model.Income_Tax = dr.GetFloat(10);
                            model.Net_Pay = dr.GetFloat(11);

                            //Display Retrieve Data
                            Console.WriteLine("{0}\t,{1}\t,{2}\t,{3}\t,{4}\t,{5}\t,{6}\t,{7}\t,{8}\t,{9}\t,{10}\t,{11}",
                                model.Id, model.Name, model.Salary, model.StartDate,
                                model.Phone_Number, model.Emp_Address, model.Emp_DEPT,
                                model.Basic_Pay, model.Deduction, model.Taxable_Pay,
                                model.Income_Tax, model.Net_Pay);

                        }
                    }
                    else
                    {
                        Console.WriteLine("No data Found");
                    }
                    //Closing SQL reader
                    dr.Close();

                    //Closing SQL Connection
                    connection.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
