using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hrms1.Models.Repositories
{
    class EmployeesRepo : ConfigRepo
    {
 
        
  

        //Inserts into table in below format
        public void InsertToTable(Employee employees)
        {

            string[] InsertMyFields = new string[] { "first_name", "last_name", "birth_date", "gender", "hire_date","password","email"};
            string[] myValues = new string[] { employees._first_name, employees._last_name,employees._birth_date, employees._gender.ToString(),employees._hire_date,employees._password,employees._email};
            AddToTable(employees.table_name, InsertMyFields, myValues);
            insertToPivotTable(employees);
         

        }
        public void insertToPivotTable(Employee employees)
        {
            MySqlCommand myQuery = this.connection.CreateCommand();
            string emp_holder = null;
            string dept_holder = null;
            if (this.OpenConnection()  == true)
            {
                myQuery.CommandText = "SELECT * FROM employees WHERE (email = '" +employees._email+ "');";
                var reader = myQuery.ExecuteReader();
                if (reader.Read())
                {
                    emp_holder = reader["emp_no"].ToString();
                    MessageBox.Show(emp_holder);
                    Console.WriteLine(emp_holder);
                }
            }
            this.CloseConnection();

            if(this.OpenConnection() == true)
            {
                myQuery.CommandText = "SELECT * FROM departments WHERE (dept_name = 'Admin')";
                var reader = myQuery.ExecuteReader();

                if (reader.Read())
                {
                    dept_holder = reader["dept_no"].ToString();
                                   }
            }
            this.CloseConnection();

            string[] myFields = new string[] { "emp_no", "dept_no","from_date" };
            string[] myValues = new string[] { emp_holder, dept_holder,employees._hire_date};
            AddToTable("dept_emp", myFields, myValues);
        }

    }
}   
