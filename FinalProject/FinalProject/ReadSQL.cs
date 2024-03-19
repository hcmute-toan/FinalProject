using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public static class ReadSQL
    {
        public static List<Jobs> Jobs()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=Test;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Jobs", connection);

                SqlDataReader reader = command.ExecuteReader();

                List<Jobs> jobs = new List<Jobs>();
                while (reader.Read())
                {
                    Jobs job = new Jobs();
                    job.Id = (string)reader["Id"];
                    job.NameJob = (string)reader["NameJob"];
                    job.PositionNeeded = (string)reader["PositionNeeded"];
                    job.CompanyName = (string)reader["CompanyName"];
                    job.Salary = (string)reader["Salary"];
                    job.Address = (string)reader["Address"];
                    job.PostingTime = (string)reader["PostingTime"];
                    job.NumberOfRecruit = (string)reader["NumberOfRecruit"];

                    jobs.Add(job);
                }
                reader.Close();
                connection.Close();
                return jobs;
            }
        }
    }
}
