using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAssignment
{
    public abstract class DbConnection
    {
        /// <summary>
        /// Gets the connection string used to connect to the database.
        /// </summary>
        public string ConnectionString { get; private set; }

        /// <summary>
        /// Gets or sets the timeout duration for opening the connection.
        /// </summary>
        public TimeSpan Timeout { get; set; }

        /// <summary>
        /// Initializes a new instance of the DbConnection class with a specified connection string.
        /// Throws an exception if the connection string is null or empty.
        /// </summary>
        /// <param name="connectionString">The connection string for the database.</param>
        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                // Ensures that a valid connection string is provided.
                throw new ArgumentException("Connection string cannot be null or empty.", nameof(connectionString));
            }
            ConnectionString = connectionString;

            // Setting a default timeout to 30 seconds.
            Timeout = TimeSpan.FromSeconds(30);
        }

        /// <summary>
        /// Opens the database connection.
        /// This method must be implemented by derived classes.
        /// </summary>
        public abstract void Open();

        /// <summary>
        /// Closes the database connection.
        /// This method must be implemented by derived classes.
        /// </summary>
        public abstract void Close();
    }
}

  
