using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Hrms1
{
    /// <summary>
    /// Class validation
    /// </summary>
    class Validation
    {
       
       

        /// <summary>
        /// Password check
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
       
        public bool PasswordValid(string password)
        {
            try
            {
                Regex regex = new Regex(@"^([a-zA-Z0-9@*#]{8,15})$");
                Match match = regex.Match(password);

                
                
                return true;
            }
            catch (Exception e)
            {   

                return false;
            }


        }
        /// <summary>
        /// Email validation
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool EmailValid(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch (Exception e)
            {

                return false;

            }
        }

        /// <summary>
        /// Checks whether the field is empty or not
        /// </summary>
        /// <param name="fields"></param>
        /// <returns></returns>
        public bool isEmpty(string[] fields)
        {
            int count = 0;
            foreach( string field in fields)
            {
                
                if(field == "")
                {
                    count++;
                    break;
                }
                
             
            }

            if (count > 0)
            {
                return true;
            }
            else
            return false; 
        }
    }
}