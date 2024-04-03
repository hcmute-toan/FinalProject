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
            foreach (Jobs job in ReadSQL.Jobs())
            {

                if (Login.IdCompany == job.CompanyId)
                {
                    UCInformationCompanies UC1 = new UCInformationCompanies();
                    UC1.lbAddress.Text = job.Address;
                    UC1.lbNameCompany.Text = job.CompanyName;
                    UC1.lbNameJob.Text = job.NameJob;
                    UC1.lbNeedPosition.Text = job.PositionNeeded;
                    UC1.lbRecruit.Text = job.NumberOfRecruit;
                    UC1.lbContact.Text = job.Contact;
                    UC1.lbTime.Text = job.PostingTime;
                    UC1.lbSalary.Text = job.Salary;
                    //this.Controls.Add(UC1);

                    flCVs.Controls.Add(UC1);
                    //UC.Click += (sender, e) =>
                    //{
                    //    MessageBox.Show("da nhan thong bao");
                    //};
                }

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Jobs job = new Jobs();

            string SQL = string.Format("INSERT INTO Jobs (CompanyId,NameJob,PositionNeeded,CompanyName,Salary,Address,PostingTime,NumberOfRecruit,Contact) VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                Login.IdCompany, tbNameJob.Text, tbPositionNeeded.Text,tbCompany.Text, tbSlary.Text, CbAddress.Text, DateTime.Now.ToString("dd/MM/yyyy"), tbRecruit.Text,tbContact.Text);
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

        private void tbCompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddImageLogoCompany_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    PtbImageLogoCompany.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static UCInformationCompanies uc1;
        private void flowLayoutPanel2_Paint(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PtbImageLogoCompany_Click(object sender, EventArgs e)
        {

        }
    }
}
