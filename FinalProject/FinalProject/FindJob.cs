using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        public FindJob()
        {
            InitializeComponent();


            //this.Controls.Add(uCInformationCompanies);
            //flowLayoutjobs.Controls.Add(uCInformationCompanies);
            reset();
        }
       
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
