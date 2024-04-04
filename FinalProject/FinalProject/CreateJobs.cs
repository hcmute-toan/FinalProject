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
using System.IO;
using System.Web.UI.WebControls;
namespace FinalProject
{
    public partial class CreateJobs : Form
    {
        public static int _idJob;
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
                    this.Controls.Add(UC1);

                    flCVs.Controls.Add(UC1);
                    UC1.Click += (sender, e) =>
                    {

                        _idJob = job.Id;
                        AcceptCVs ac = new AcceptCVs();
                        ac.ShowDialog();
                    };
                }

            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            byte[] b = PathToByteArray(this.Text);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Jobs values(@CompanyId, @NameJob,@PositionNeeded,@CompanyName,@Salary,@Address,@PostingTime,@NumberOfRecruit,@DescribeJob,@Contact)", conn);
            cmd.Parameters.Add("@CompanyId", Login.IdCompany);
            cmd.Parameters.Add("@NameJob", tbNameJob.Text);
            cmd.Parameters.Add("@PositionNeeded", tbPositionNeeded.Text);
            cmd.Parameters.Add("@CompanyName", tbCompany.Text);
            cmd.Parameters.Add("@Salary", tbSlary.Text);
            cmd.Parameters.Add("@Address", CbAddress.Text);
            cmd.Parameters.Add("@PostingTime", DateTime.Now.ToString("dd/MM/yyyy"));
            cmd.Parameters.Add("@NumberOfRecruit", tbRecruit.Text);
            cmd.Parameters.Add("@DescribeJob", tbDescribeJob.Text);
            cmd.Parameters.Add("@Contact", tbContact.Text);

            SqlCommand CMD1 = new SqlCommand("UPDATE Employers SET Picture = @PictureParam WHERE Id = @IdParam", conn);
            // Cung cấp giá trị cho các thamSqlParameter
            CMD1.Parameters.Add("@PictureParam", b);
            CMD1.Parameters.Add("@IdParam", Login.IdCompany);
            if (cmd.ExecuteNonQuery() > 0 && CMD1.ExecuteNonQuery() > 0)
            { MessageBox.Show("Succcess!!!"); }
            else
            {
                MessageBox.Show("Fail!!!");
            }
            conn.Close();
        }

        private void tbCompany_TextChanged(object sender, EventArgs e)
        {

        }
        byte[] PathToByteArray(string path)
        {
            MemoryStream m = new MemoryStream();
            System.Drawing.Image img = System.Drawing.Image.FromFile(path);
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
       
        private void btnAddImageLogoCompany_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                PtbImageLogoCompany.Image = System.Drawing.Image.FromFile(open.FileName);
                this.Text = open.FileName;
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

        private void CbAddress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbSlary_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
