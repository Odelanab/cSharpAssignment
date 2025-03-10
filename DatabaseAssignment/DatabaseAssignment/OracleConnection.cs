using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAssignment
{
    public class OracleConnection: DbConnection
    {
        /// <summary>
        /// Initializes a new instance of the OracleConnection class.
        /// </summary>
        /// <param name="connectionString">The connection string for the Oracle database.</param>
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        /// <summary>
        /// Opens the Oracle connection.
        /// </summary>
        public override void Open()
        {
            // Simulate opening an Oracle connection by printing a message.
            Console.WriteLine("Opening Oracle connection with connection string: " + ConnectionString);
        }

        /// <summary>
        /// Closes the Oracle connection.
        /// </summary>
        public override void Close()
        {
            // Simulate closing an Oracle connection by printing a message.
            Console.WriteLine("Closing Oracle connection.");
        }
    }
}

   