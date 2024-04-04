using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class AcceptCV : Form
    {
        SqlConnection conn = new
        SqlConnection(Properties.Settings.Default.ConnStr);
        public AcceptCV()
        {
            InitializeComponent();
            foreach(UserAccount a in ReadSQL.Accounts())
            {
                if(AcceptCVs._idUser ==a.Id)
                {
                    ptbImageUser.Image = ConvertImage.ByteArrayToImage(a.Picture);
                }
            }
            lbName.Text = AcceptCVs.cvtmp.Name;
            lbAddress.Text = AcceptCVs.cvtmp.Address;
            lbGender.Text = AcceptCVs.cvtmp.Gender;
            lbDateOfBirth.Text = AcceptCVs.cvtmp.DateOfBirth;
            tbWorkExperience.Text = AcceptCVs.cvtmp.WorkExperience;
            tbCertifications.Text = AcceptCVs.cvtmp.EducationAndCertifications;
            tbSkills.Text = AcceptCVs.cvtmp.ProfessionalSkills;
            tbGoals.Text = AcceptCVs.cvtmp.GoalAtWork; 
        }

        private void AcceptCV_Load(object sender, EventArgs e)
        {
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            int Status = 1;
            SqlCommand CMD1 = new SqlCommand("UPDATE JobApplication SET Status = @Status WHERE UserId = @UserId AND JobId = @JobId AND CompanyId = @CompanyId", conn);
            CMD1.Parameters.Add("@Status", Status);
            CMD1.Parameters.Add("@UserId", AcceptCVs._idUser);
            CMD1.Parameters.Add("@JobId", CreateJobs._idJob);
            CMD1.Parameters.Add("@CompanyId", Login.IdCompany);
            if (CMD1.ExecuteNonQuery() > 0)
            { MessageBox.Show("Succcess!!!"); }
            else
            {
                MessageBox.Show("Fail!!!");
            }
            conn.Close();
        }
    }
}
