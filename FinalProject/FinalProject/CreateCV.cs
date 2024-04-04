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

namespace FinalProject
{
    public partial class CreateCV : Form
    {
        SqlConnection conn = new
         SqlConnection(Properties.Settings.Default.ConnStr);
        public static int STATIC = 0;
        public CreateCV()
        {
            InitializeComponent();
            foreach(UserAccount a in ReadSQL.Accounts())
            {
                if(a.Id == Login.IdUser)
                {
                    ptbImageUser.Image = ConvertImage.ByteArrayToImage(a.Picture);
                }
            }
            foreach ( CV cv in ReadSQL.Cvs())
            {
                if (cv.Id == Login.IdUser)
                {
                    lbName.Text = cv.Name;
                    lbGender.Text = cv.Gender;
                    lbAddress.Text = cv.Address;
                    lbDateOfBirth.Text = cv.DateOfBirth;
                    tbWorkExperience.Text = cv.WorkExperience;
                    tbCertifications.Text = cv.EducationAndCertifications;
                    tbSkills.Text = cv.ProfessionalSkills;
                    tbGoals.Text = cv.GoalAtWork;
                }
            }
        }
        private void CreateCV_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into JobApplication values(@UserId, @JobId, @CompanyId,@Status)", conn);
            cmd.Parameters.Add("@UserId", Login.IdUser);
            cmd.Parameters.Add("@JobId", FindJob.IDJOB);
            cmd.Parameters.Add("@CompanyId", FindJob.IDCOMPANY);
            cmd.Parameters.Add("@Status", STATIC);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Succcess!!!"); 
            }
            else
            {
                MessageBox.Show("Fail!!!");
            }
            conn.Close();
        }

        private void tbWorkExperience_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
