using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAssignment
{
    public class SqlConnection:DbConnection
    {
        /// <summary>
        /// Initializes a new instance of the SqlConnection class with the specified connection string.
        /// </summary>
        /// <param name="connectionString">The connection string for the SQL Server database.</param>
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        /// <summary>
        /// Opens the SQL Server connection.
        /// </summary>
        public override void Open()
        {
            // Simulate opening a SQL Server connection by printing a message.
            Console.WriteLine("Opening SQL Server connection with connection string: " + ConnectionString);
        }

        /// <summary>
        /// Closes the SQL Server connection.
        /// </summary>
        public override void Close()
        {
            // Simulate closing a SQL Server connection by printing a message.
            Console.WriteLine("Closing SQL Server connection.");
        }
    }
}
