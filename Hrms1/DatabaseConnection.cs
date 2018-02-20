using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Connection
{
    public class DatabaseConnection
    {
        /// <summary>
        /// dynamic connection to database, modify only variables
        /// </summary>
       
        private string server = "localhost"; //your server name
        private string database="hrms"; //your database name
        private string uid ="root"; //your user id
        private string password = ""; //your password


        /// <summary>
        ///  DONOT MODIFY AFTER THIS!!
        /// </summary>
        private string ConnectionString;
        private MySqlConnection connection;


        public DatabaseConnection()
        {
            Initialize();
        }

        private void Initialize()
        {
            ConnectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(ConnectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }

            catch(MySqlException ex)
            {
                switch (ex.Number) {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;

                }
                return false;

            }
            finally
            {
                connection.Close();
            }
        }

    }
}