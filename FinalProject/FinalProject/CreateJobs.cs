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

            string SQL = string.Format("INSERT INTO Jobs (CompanyId,NameJob,PositionNeeded,CompanyName,Salary,Address,PostingTime,NumberOfRecruit,Contact) VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                Login.IdCompany, tbNameJob.Text, tbPositionNeeded.Text,tbCompany.Text, tbSlary.Text, tbAddress.Text, DateTime.Now.ToString("dd/MM/yyyy"), tbRecruit.Text,tbContact.Text);
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
    }
}
