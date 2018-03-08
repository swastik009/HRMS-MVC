using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Config;
namespace Hrms1.Models
{



    public enum Gender { male, female, others };

    class Employees
    {
        /// <summary>
        /// variables for employees
        /// </summary>
        public string table_name = "Employees";
        public int _emp_no { get; set; }
        public string _first_name { get; set; }
        public string _last_name { get; set; }
        public string _birth_date { get; set; }
        
        public Gender _gender { get; set; }
        public string _hire_date { get; set; }


        //adds databaseConfiguration 
        DatabaseConfiguration connection = new DatabaseConfiguration();
        

        //CreatesTable with below format
        public void CreateTable()
        {
            string[] CreateMyFields = new string[] { "emp_no", "first_name", "last_name", "birth_date", "gender", "hire_date" };
            string[] dataTypes = new string[] { "INT PRIMARY KEY AUTO_INCREMENT NOT NULL", "VARCHAR(255) NOT NULL", "VARCHAR(255) NOT NULL", "DATE NOT NULL", "ENUM('male', 'female', 'other') NOT NULL", "DATE NOT NULL" };
            connection.CreateTable(table_name, CreateMyFields, dataTypes);
        }
        
        //Inserts into table in below format
        public void InsertToTable()
        {
            
            string[] InsertMyFields = new string[] {  "first_name","last_name", "birth_date", "gender", "hire_date" };
            string[] myValues = new string[] { _first_name, _last_name, _birth_date, _gender.ToString(), _hire_date };
            connection.AddToTable(table_name, InsertMyFields, myValues); 

        }
       
    }
}
