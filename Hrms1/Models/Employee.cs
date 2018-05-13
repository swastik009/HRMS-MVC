using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hrms1.Models.Repositories;
namespace Hrms1.Models
{


    
    public enum Gender { male, female, others };

    class Employee 
    {
        /// <summary>
        /// variables for employees
        /// </summary>
        public string table_name = "Employees";
        public string _first_name { get; set; }
        public string _last_name { get; set; }
        public string _birth_date { get; set; }
        //DateTime oDate = DateTime.Parse(_birth_date);
        public Gender _gender { get; set; }
        public string _hire_date { get; set; }
        public string _password { get; set; }
        public string _email { get; set; }
    
        


       
    }
}
