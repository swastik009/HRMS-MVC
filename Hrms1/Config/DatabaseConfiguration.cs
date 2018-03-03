using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Config
{
    public class DatabaseConfiguration
    {
        
       
      
            
        /// <summary>
        ///  DONOT MODIFY AFTER THIS!!
        /// </summary>
        private string ConnectionString;
        private MySqlConnection connection;

        /// <summary>
        /// DatabaseConnection Constructor
        /// </summary>
        public DatabaseConfiguration()
        {
            Initialize();

        }


        /// <summary>
        /// Initializing the connection
        /// </summary>
        private void Initialize()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
            connection = new MySqlConnection(ConnectionString);
            
        }

        /// <summary>
        /// Checking if Connection is open or not
        /// </summary>
        /// <returns></returns>
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
            
          
        }

        /// <summary>
        /// checking if connection is close or not
        /// </summary>
        /// <returns></returns>

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Method for creating table
        /// Accepts tablename, fieldnames in string array, and datatypes in string array
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="fieldNames"></param>
        /// <param name="dataTypes"></param>
        /// <example>string[] myFields = new string[]{"asdf","aklsdjf"};</example>
        /// string[] myTypes = new string[]{"int", "varchar(20)"};
        /// DatabaseConnection.CreateTable("asjdfkl",myFields, myTypes);
        private void CreateTable(string tableName, string[] fieldNames, string[] dataTypes)
        {
            if (this.OpenConnection() == true)
            {
                string myQuery = "CREATE TABLE " + tableName;
                myQuery += " (";
                for (int i = 0; i < fieldNames.Length; i++)
                {
                    if (i == 0)
                        myQuery += fieldNames[i] + " " + dataTypes[i];
                    else
                        myQuery += ", " + fieldNames[i] + " " + dataTypes[i];
                }
                myQuery += ")";
                MySqlCommand cmd = new MySqlCommand(myQuery, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }

        }

        /// <summary>
        /// Method for inserting into table
        /// Accepts tablename, fieldnames in string array, and values in string array
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="fieldNames"></param>/
        /// <param name="values"></param>
        private void AddToTable(string tableName, string[] fieldNames, string[] values)
        {
            if (this.OpenConnection() == true)
            {
                string myQuery = "INSERT INTO " + tableName;
                myQuery += " (";
                for (int i = 0; i < fieldNames.Length; i++)
                {
                    if (i == 0)
                        myQuery += fieldNames[i];
                    else
                        myQuery += ", " + fieldNames[i];

                }
                myQuery += ") VALUES (";
                for (int i = 0; i < values.Length; i++)
                {
                    if (i == 0)
                        myQuery += "'" + values[i] + "'";
                    else
                        myQuery += ", '" + values[i] + "'";
                }
                myQuery += ");";
                MySqlCommand cmd = new MySqlCommand(myQuery, connection);
                cmd.ExecuteNonQuery();
            }
            
            this.CloseConnection();
        }

       


    }


}