using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;


namespace Configuration
{
    public class ConfigRepo
    {
        
       
      
            
        /// <summary>
        /// THIS IS AN ABSTRACT CLASS, DONOT MODIFY AFTER THIS!!
        /// </summary>
        protected string ConnectionString;
        protected MySqlConnection connection;
        protected string DataBaseName;
       
        /// <summary>
        /// DatabaseConnection Constructor
        /// </summary>
        public ConfigRepo()
        {
            Initialize();

        }

       

        /// <summary>
        /// Initializing the connection
        /// </summary>
        public void Initialize()
        {
            //setting connection string
            ConnectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
            this.connection = new MySqlConnection(ConnectionString);

            //getting the Database Name from App.Config 
            System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder(ConnectionString);
            this.DataBaseName = builder.InitialCatalog;
        }

        

        /// <summary>
        /// Checking if Connection is open or not
        /// </summary>
        /// <returns></returns>
        public bool OpenConnection()
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

        public bool CloseConnection()
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
        public void CreateTable(string tableName, string[] fieldNames, string[] dataTypes)
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

                QueryExecuter(myQuery).ExecuteNonQuery();
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
        public void AddToTable(string tableName, string[] fieldNames, string[] values)
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
                
                QueryExecuter(myQuery).ExecuteNonQuery();
            }
            
            this.CloseConnection();
        }



        /// <summary>
        /// Checks if the table exists or not.  
        /// Returns 0 or more than 0.
        /// If returns more than 0 then Table exists
        /// </summary>
        /// <example>if(CheckTableExists > 0) 
        /// Table exists 
        ///else
        ///Table doesnot exists
        ///</example>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public int CheckTableExists(string tableName)
        {
            //Initializing Count as -1 
            int count = -1;
            if (this.OpenConnection() == true)
            {
                string myQuery = "SELECT count(*) FROM information_schema.TABLES WHERE (TABLE_SCHEMA = '" + this.DataBaseName + "') AND (TABLE_NAME = '" + tableName + "')";
                
                count = int.Parse(QueryExecuter(myQuery).ExecuteScalar() + "");
            }
            
            this.CloseConnection();
            return count;
        }


        /// <summary>
        /// Authenticates email and password exists in particular table
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>

        public int checkLoginAuth(string tableName, string email, string password)
        {
            int count = -1;
            if(this.OpenConnection() == true)
            {
                string myQuery = "SELECT count(*) FROM " + tableName + " WHERE (email = '" + email + "' AND password = '" + password + "');";
                count = int.Parse(QueryExecuter(myQuery).ExecuteScalar() + "");
                //MessageBox.Show(count.ToString());
            }
            this.CloseConnection();
            return count;

        }

        /// <summary>
        /// Checks whether given email address is admin or not
        /// </summary>
        /// <param name="emp_no"></param>
        /// <param name="dept_no"></param>
        /// <param name="tableName"></param>
        /// <param name="tableName1"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool checkAdmin(string mainTable, string tableName1, string tableName2,string email)
        {
            
            string holder = null;
            string myQuery= "SELECT dept_name FROM " +mainTable+" de INNER JOIN " +tableName1+ " e ON de.emp_no = e.emp_no INNER JOIN " +tableName2+ " d ON de.dept_no = d.dept_no WHERE e.email = '"+email+"'";

            if (this.OpenConnection() == true)

                
            {
                var reader = QueryExecuter(myQuery).ExecuteReader();
                if (reader.Read())
                    holder = reader["dept_name"].ToString();
                    this.CloseConnection();
               
            }

            if (holder == "Admin")
                return true;
            else
                return false;

        }
       
        public int CheckDataExist(string table)
        {
            int Count = -1;

            if (this.OpenConnection() == true)
            {
                string myQuery = "SELECT count(*) FROM " + table;
                
                Count = int.Parse(QueryExecuter(myQuery).ExecuteScalar() + "");
            }
            this.CloseConnection();
            return Count;
        }

        /// <summary>
        /// QueryExecuter is to execute the query
        /// </summary>
        /// <param name="myQuery"></param>
        /// <returns></returns>
        public MySqlCommand QueryExecuter (string myQuery)
        {
            MySqlCommand cmd = new MySqlCommand(myQuery, this.connection);
            return cmd;
        }

        

    }


}