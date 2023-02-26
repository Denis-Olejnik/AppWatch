using System.Configuration;
using System.Data.SqlClient;

namespace AppWatch.Model
{
    internal class ProcessDataContext
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        
        public List<Process> GetProcesses()
        {
            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            
            SqlCommand command = new SqlCommand("SELECT Title, Executable, Path, CommandLine FROM Processes", connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                var processes = new List<Process>();
                while (reader.Read())
                {
                    processes.Add(new Process
                    {
                        Title = (string)reader["Title"],
                        Executable = (string)reader["Executable"],
                        Path = (string)reader["Path"],
                        CommandLine = (string)reader["CommandLine"]
                    });
                }
                return processes;
            }
        }

        /// <summary>
        /// Writing an object of class "Process" to the database
        /// </summary>
        /// <param name="process">Object with parameters such as: @Title, @Executable, @Path, @CommandLine</param>
        public void AddProcess(Process process)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Processes VALUES (@Title, @Executable, @Path, @CommandLine)", connection);
                command.Parameters.AddWithValue("@Title", process.Title);
                command.Parameters.AddWithValue("@Executable", process.Executable);
                command.Parameters.AddWithValue("@Path", process.Path);
                command.Parameters.AddWithValue("@CommandLine", process.CommandLine);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteProcess(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("DELETE FROM Processes WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
