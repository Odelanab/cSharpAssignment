using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAssignment
{
    class Program
    {
        static void Main()
        {
            try
            {
                // Create an instance of SqlConnection with a sample connection string.
                DbConnection sqlConnection = new SqlConnection("SQL_Server_Connection_String");

                // Create a DbCommand using the SQL connection and a sample SQL query.
                DbCommand sqlCommand = new DbCommand(sqlConnection, "SELECT * FROM Users");
                sqlCommand.Execute();  // This simulates opening, executing, and closing the connection.

                Console.WriteLine();  // Print a blank line for separation.

                // Create an instance of OracleConnection with a sample connection string.
                DbConnection oracleConnection = new OracleConnection("Oracle_Connection_String");

                // Create a DbCommand using the Oracle connection and a sample SQL query.
                DbCommand oracleCommand = new DbCommand(oracleConnection, "SELECT * FROM Customers");
                oracleCommand.Execute();  // This simulates opening, executing, and closing the connection.
            }
            catch (Exception ex)
            {
                // Catch and display any errors that occur during execution.
                Console.WriteLine("Error: " + ex.Message);
            }

            // Keep the console window open until the user presses Enter.
            Console.ReadLine();
        }
    }
}
