using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace FinalProject
{
    public partial class CreateJobs : Form
    {
        SqlConnection conn = new
         SqlConnection(Properties.Settings.Default.ConnStr);
        public CreateJobs()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Jobs job = new Jobs();

            string SQL = string.Format("INSERT INTO Jobs (CompanyId,NameJob,PositionNeeded,CompanyName,Salary,Address,PostingTime,NumberOfRecruit,Contact) VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", Login.IdCompany, job.NameJob, job.PositionNeeded, job.CompanyName, job.Salary, job.Address, job.PostingTime, job.NumberOfRecruit,  job.Contact);
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Successful!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail!!!" + ex);
            }
            finally
            {
                conn.Close();
            }


        }
    }
}
