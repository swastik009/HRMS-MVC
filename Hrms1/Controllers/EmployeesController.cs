using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hrms1.Models;
using Hrms1.Models.Repositories;
using Hrms1.Models.Validations;
using System.Diagnostics;
using System.Windows.Forms;

namespace Hrms1.Controllers
{
    

    class EmployeesController 
    {

       
        EmployeesRepo employeesRepos = new EmployeesRepo();
        EmployeeValidation employeeval = new EmployeeValidation();
        Employee emp = new Employee();
        
       
        




        public void Create(string first_name, string last_name, string birth_date, string gender, string hire_date,string password,string email)
        {
            
                emp._first_name = first_name;
                emp._last_name = last_name;
                emp._birth_date = birth_date;
                //converting string gender into Enum Gender
                
                emp._gender = (Gender)Enum.Parse(typeof(Gender), gender);

                emp._hire_date = hire_date;
                emp._password = password;
                emp._email = email;
                
                
               
                if (employeeval.valChecker(emp) == true)
                {
                    employeesRepos.InsertToTable(emp);
                    MessageBox.Show("SUCCESS");
                    //sgn.Hide();
                }

            
            
        }
        

    }
}
