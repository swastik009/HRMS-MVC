using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hrms1.Models;
using System.Windows.Forms;
using System.Diagnostics;

namespace Hrms1.Models.Validations
{
    class EmployeeValidation 
    {
        /// <summary>
        /// only write fillables in here 
        /// </summary>

        
        
        public bool valChecker(Employee emp)
        {
            
            Validation validateEmployee = new Validation();
            //MessageBox.Show(emp._first_name);
            string[] myFields = new string[] { emp._first_name,emp._last_name, emp._email, emp._password };



            if (validateEmployee.isEmpty(myFields) != true)
            {

                if (validateEmployee.PasswordValid(emp._password) == false)
                {
                    MessageBox.Show("Password Must have one Capital letter/Number/ and should range from 8-15 character ");
                    return false;
                }

                else if (validateEmployee.EmailValid(emp._email) == false)
                {
                    MessageBox.Show("Incorrect Email format");
                    return false;

                }
                else
                    return true;
            }

            else
            {
                MessageBox.Show("Required field is empty (*) are required fields");
                return false;

            }



            


       }
       



           


    }
}
