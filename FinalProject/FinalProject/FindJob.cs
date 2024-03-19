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
    public partial class FindJob : Form
    {
        public FindJob()
        {
            InitializeComponent();
    
            foreach (Jobs job in ReadSQL.Jobs())
            {
                
                UCInformationCompanies UC= new UCInformationCompanies();
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
            }
            
            //this.Controls.Add(uCInformationCompanies);
            //flowLayoutjobs.Controls.Add(uCInformationCompanies);




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
    }
}
