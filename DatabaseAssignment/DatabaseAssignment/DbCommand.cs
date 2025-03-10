using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAssignment
{
   public class DbCommand
    {
        // Private field holding the database connection.
        private readonly DbConnection _connection;

        /// <summary>
        /// Gets the command text to be executed.
        /// </summary>
        public string CommandText { get; private set; }

        /// <summary>
        /// Initializes a new instance of the DbCommand class.
        /// Validates that the connection and command text are provided.
        /// </summary>
        /// <param name="connection">The database connection to be used. Cannot be null.</param>
        /// <param name="commandText">The command text to execute. Cannot be null or empty.</param>
        public DbCommand(DbConnection connection, string commandText)
        {
            // Validate that a non-null connection is provided.
            _connection = connection ?? throw new ArgumentException("Connection cannot be null.", nameof(connection));

            // Validate that a valid command text is provided.
            if (string.IsNullOrWhiteSpace(commandText))
            {
                throw new ArgumentException("Command text cannot be null or empty.", nameof(commandText));
            }
            CommandText = commandText;
        }

        /// <summary>
        /// Executes the command.
        /// Opens the connection, simulates command execution by printing the command text,
        /// and then closes the connection.
        /// </summary>
        public void Execute()
        {
            // Open the connection 
            _connection.Open();

            // Simulate execution of the command by printing it.
            Console.WriteLine("Executing command: " + CommandText);

            // Close the connection.
            _connection.Close();
        }
    }
}


