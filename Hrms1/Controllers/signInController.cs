﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hrms1;
using Configuration;
using System.Windows.Forms;
namespace Hrms1.Controllers
{
    class signInController : ConfigRepo
    {
     
        public void LoginAuth(string email, string password)
        {
            if (checkLoginAuth("employees", email, password) >= 1)
            {
                if (checkAdmin("dept_emp", "employees", "departments", email) == true)
                    MessageBox.Show("Show Admin Page");
                else
                    MessageBox.Show("Show User Page");               
            }
            else
            {
                MessageBox.Show("cannot access");
            }
        }
        
    }
}
