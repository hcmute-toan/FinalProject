using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FindJob : Form
    {
        public static UCInformationCompanies uc;

        public object Gdip { get; private set; }

        public FindJob()
        {
            InitializeComponent();
            reset();
        }

            //public static Image byteArayToImage(byte[] b)
            //{
            //    using (MemoryStream m = new MemoryStream(b))
            //    {
            //        ImageConverter converter = new ImageConverter();
            //        return (Image)converter.ConvertFrom(m);
            //    }
            //}

            public void reset()
            {
                flowLayoutjobs.Controls.Clear();
                foreach (Jobs job in ReadSQL.Jobs())
                {
                    UCInformationCompanies UC = new UCInformationCompanies();
                    UC.lbAddress.Text = job.Address;
                    UC.lbNameCompany.Text = job.CompanyName;
                    UC.lbNameJob.Text = job.NameJob;
                    UC.lbNeedPosition.Text = job.PositionNeeded;
                    UC.lbRecruit.Text = job.NumberOfRecruit;
                    UC.lbContact.Text = job.Contact;
                    UC.lbTime.Text = job.PostingTime;
                    UC.lbSalary.Text = job.Salary;

                    //byte[] b;
                    //b = job.Image1;
                    //MessageBox.Show("Đây là thôngbyte " + b);
                    //Image kaka = byteArayToImage(b);
                    //MessageBox.Show("Đây là thôngimage " + kaka);

                    //UC.PicBoxLogoCompany.Image = kaka;
                    //byte[] b;
                    //b = job.Image1;

                    // Kiểm tra xem mảng byte có dữ liệu không
                    //if (b != null)
                    //{
                    //    // Tạo một MemoryStream từ mảng byte
                    //    using (MemoryStream ms = new MemoryStream(b))
                    //    {
                    //        // Tạo một hình ảnh từ MemoryStream
                    //        Image kaka = Image.FromStream(ms);

                    //        // Gán hình ảnh cho PictureBox
                    //        UC.PicBoxLogoCompany.Image = kaka;

                    //        // Hiển thị thông báo
                    //        MessageBox.Show("Đã gán hình ảnh từ mảng byte cho PictureBox.");
                    //    }
                    //}
                    //else
                    //{
                    //    // Hiển thị thông báo nếu mảng byte không có dữ liệu
                    //    MessageBox.Show("Mảng byte không có dữ liệu hình ảnh.");
                    //}

                    this.Controls.Add(UC);

                    flowLayoutjobs.Controls.Add(UC);
                    UC.Click += (sender, e) =>
                    {
                        uc = UC;
                        DescribeJob describeJob = new DescribeJob();
                        describeJob.ShowDialog();
                    };
                }

            }
       

            private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void flowLayoutjobs_Paint(object sender, PaintEventArgs e)
            {

            }

            private void guna2Panel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void tabPage1_Click(object sender, EventArgs e)
            {

            }

            private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void FindJob_Load(object sender, EventArgs e)
            {

            }

            private void TbFind_TextChanged(object sender, EventArgs e)
            {

            }
            public void FindJobByNameAndAddress()
            {

                foreach (Jobs job in ReadSQL.Jobs())
                {
                    if (TbFind.Text.ToUpper().Replace(" ", "") == job.NameJob.ToUpper().Replace(" ", ""))
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

                        flowLayoutjobs.Controls.Add(UC1);
                        UC1.Click += (sender, e) =>
                        {
                            uc = UC1;
                            DescribeJob describeJob = new DescribeJob();
                            describeJob.ShowDialog();
                        };
                    }
                    if (TbFind.Text.ToUpper().Replace(" ", "") == "" && CBAddress.Text.ToUpper().Replace(" ", "") == job.Address.ToUpper().Replace(" ", ""))
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

                        flowLayoutjobs.Controls.Add(UC1);
                        UC1.Click += (sender, e) =>
                        {
                            uc = UC1;
                            DescribeJob describeJob = new DescribeJob();
                            describeJob.ShowDialog();
                        };
                    }
                    if (TbFind.Text.ToUpper().Replace(" ", "") == job.NameJob.ToUpper().Replace(" ", "") && CBAddress.Text.ToUpper().Replace(" ", "") == job.Address.ToUpper().Replace(" ", ""))
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

                        flowLayoutjobs.Controls.Add(UC1);
                        UC1.Click += (sender, e) =>
                        {
                            uc = UC1;
                            DescribeJob describeJob = new DescribeJob();
                            describeJob.ShowDialog();
                        };
                    }
                }
            }
            public void guna2CirclePictureBox2_Click(object sender, EventArgs e)
            {
                flowLayoutjobs.Controls.Clear();
                FindJobByNameAndAddress();
            }

            private void btnReset_Click(object sender, EventArgs e)
            {
            reset();
        }
        }
    }
