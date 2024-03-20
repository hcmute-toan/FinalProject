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
            string connectionString = "Data Source=TonyNyan\\TONYNYAN;Initial Catalog=ManagerJobs;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Jobs", connection);

                SqlDataReader reader = command.ExecuteReader();

                List<Jobs> jobs = new List<Jobs>();
                while (reader.Read())
                {
                    Jobs job = new Jobs();
                    job.Id = (int)reader["Id"];
                   // job.CompanyId = (int)reader["CompanyId"];
                    job.NameJob = (string)reader["NameJob"];
                    job.PositionNeeded = (string)reader["PositionNeeded"];
                    job.CompanyName = (string)reader["CompanyName"];
                    job.Salary = (string)reader["Salary"];
                    job.Address = (string)reader["Address"];
                    job.PostingTime = (string)reader["PostingTime"];
                    job.NumberOfRecruit = (string)reader["NumberOfRecruit"];
                    //job.Contact = (string)reader["Contact"];
                    
                    jobs.Add(job);
                }
                reader.Close();
                connection.Close();
                return jobs;
            }
        }
        public static List<UserAccount> Accounts()
        {
            string connectionString = "Data Source=TonyNyan\\TONYNYAN;Initial Catalog=ManagerJobs;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Candidates", connection);

                SqlDataReader reader = command.ExecuteReader();
                List<UserAccount> accounts = new List<UserAccount>();
                while (reader.Read())
                {
                    UserAccount account = new UserAccount();
                    account.Id = (int)reader["Id"];
                    account.Gmail = (string)reader["Gmail"];
                    account.UserName = (string)reader["Name"];
                    account.Password = (string)reader["Password"];

                    accounts.Add(account);
                }
                reader.Close();
                connection.Close();
                return accounts;
            }
        }

        public static List<Employers> Company()
        {
            string connectionString = "Data Source=TonyNyan\\TONYNYAN;Initial Catalog=ManagerJobs;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Employers", connection);

                SqlDataReader reader = command.ExecuteReader();
                List<Employers> accounts = new List<Employers>();
                while (reader.Read())
                {
                    Employers account = new Employers();
                    account.Id = (int)reader["Id"];
                    account.Gmail = (string)reader["Gmail"];
                    account.UserName = (string)reader["Name"];
                    account.Password = (string)reader["Password"];

                    accounts.Add(account);
                }
                reader.Close();
                connection.Close();
                return accounts;
            }
        }
    }
}
