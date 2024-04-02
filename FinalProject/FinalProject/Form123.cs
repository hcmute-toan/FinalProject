
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form123 : Form
    {
        SqlConnection conn = new
SqlConnection(Properties.Settings.Default.ConnStr);
        public Form123()
        {
            InitializeComponent();

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
        }
       //public  Image byteArayToImage(byte[] b)
       // {

       //     using (MemoryStream m = new MemoryStream(b))
       //     {
       //         return Image.FromStream(m);
       //     }
       // }
        //private void Form123_Load(object sender, EventArgs e)
        //{

        //    //UCInformationCompanies UC = new UCInformationCompanies();
        //    //UC.lbAddress.Text = job.Address;
        //    //UC.lbNameCompany.Text = job.CompanyName;
        //    //UC.lbNameJob.Text = job.NameJob;
        //    //UC.lbNeedPosition.Text = job.PositionNeeded;
        //    //UC.lbRecruit.Text = job.NumberOfRecruit;
        //    //UC.lbContact.Text = job.Contact;
        //    //UC.lbTime.Text = job.PostingTime;
        //    //UC.lbSalary.Text = job.Salary;

        //    try
        //    {
        //        conn.Open();
        //        string sqlStr = string.Format("SELECT *FROM Jobs");
               
        //        SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
        //        DataTable dtSinhVien = new DataTable();
        //        adapter.Fill(dtSinhVien);
        //        foreach (Jobs job in ReadSQL.Jobs())
        //        {
        //            if (job.NameJob == "qweqw")
        //            {
        //                MyDbContextDataContext myDb = new MyDbContextDataContext();

        //                if (job.Image1 == null)
        //                {
        //                    MessageBox.Show("Đây là thông bao loi null");
        //                }
        //              pic1.Image =  byteArayToImage(job.Image1);



        //            }


        //        }

        //    }
        //    //catch (Exception exc)
        //    //{
        //    //    MessageBox.Show(exc.Message);
        //    //}
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

        private void ofdopenfile_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void themmm_Click(object sender, EventArgs e)
        {
            ofdopenfile.ShowDialog();
            string file = ofdopenfile.FileName;
            if (string.IsNullOrEmpty(file))
            { return; }

            Image myImage = Image.FromFile(file);
            pic1.Image = myImage;
        }

        private void loadđ_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pic1.Image.Save(stream, ImageFormat.Jpeg);
            MyDbContextDataContext myDb = new MyDbContextDataContext();
            met pic = new met();
            pic.pic = stream.ToArray();
            pic.name = "MyName";
            myDb.mets.InsertOnSubmit(pic);
            myDb.SubmitChanges();
            MessageBox.Show("thanh cong");


        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            MyDbContextDataContext myDb = new MyDbContextDataContext();
            met pic = myDb.mets.Where(em => em.name == "MyName").FirstOrDefault();
            if (pic == null)
                return;
            MemoryStream memory = new MemoryStream(pic.pic.ToArray());
            Image img = Image.FromStream(memory);
            if(img != null)
            {
                return;
            }    
            pictureBox12.Image = img;   

        }
    }
}
