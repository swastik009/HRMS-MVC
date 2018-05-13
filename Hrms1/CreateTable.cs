using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configuration;
namespace Hrms1
{
    /// <summary>
    /// This class shall be executed only once 
    /// </summary>
    class CreateTable
    {

        ConfigRepo Create = new ConfigRepo();
        public CreateTable()
        {
            createEmployees();
            createDeptTable();
            createDept_emp();
            createDept_manager();
            createSalaries();
            createTitles();

        }
        public void createEmployees()
        {
          
                string[] CreateMyFields = new string[] { "emp_no", "first_name", "last_name", "birth_date", "gender", "hire_date", "password", "email" };
                string[] dataTypes = new string[] { "INT PRIMARY KEY AUTO_INCREMENT NOT NULL", "VARCHAR(255) NOT NULL", "VARCHAR(255) NOT NULL", "DATE NOT NULL", "ENUM('male', 'female', 'other') NOT NULL", "DATE NOT NULL", "VARCHAR(255) NOT NULL", "VARCHAR(255) NOT NULL" };
                Create.CreateTable("Employees", CreateMyFields, dataTypes);
                                
        }
        public void createDeptTable()
        {
            
            string[] myFields = new string[] { "dept_no", "dept_name" };
            string[] dataType = new string[] { "char PRIMARY KEY NOT NULL", "VARCHAR(40) NOT NULL" };
            Create.CreateTable("departments", myFields, dataType);
        }

        public void createDept_emp()
        {
            string[] myFields = new string[] { "emp_no", "dept_no","from_date","to_date" };
            string[] dataType = new string[] { "int", "char","DATE","DATE", "FOREIGN KEY REFERENCES Employees(emp_no)","FOREIGN KEY REFERENCES dept_emp(dept_no)" };
            Create.CreateTable("dept_emp", myFields, dataType);
        }

        public void createDept_manager()
        {
            string[] myFields = new string[] { "dept_no", "emp_no", "from_date", "to_date" };
            string[] dataType = new string[] { "char", "int", "DATE", "DATE","FOREIGN KEY REFERENCES dept_emp(dept_no)", "FOREIGN KEY REFERENCES Employees(emp_no)" };
            Create.CreateTable("dept_manager", myFields, dataType);
        }

        public void createSalaries()
        {
            string[] myFields = new string[] { "emp_no", "salaries", "from_date", "to_date" };
            string[] dataType = new string[] { "int", "int NOT NULL", "DATE", "DATE","FOREIGN KEY REFERENCES Employees(emp_no)" };
            Create.CreateTable("salaries", myFields, dataType);
        }

        public void createTitles()
        {
            string[] myFields = new string[] { "emp_no", "title", "from_date", "to_date" };
            string[] dataType = new string[] { "int", "VARCHAR(50) NOT NULL", "DATE", "DATE", "FOREIGN KEY REFERENCES Employees(emp_no)" };
            Create.CreateTable("titles", myFields, dataType);
        }

        

    }
}
