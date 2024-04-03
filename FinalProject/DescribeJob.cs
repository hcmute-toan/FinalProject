using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class DescribeJob : Form
    {
        public DescribeJob()
        {
            InitializeComponent();
            TbCompany.Text = FindJob.uc.lbNameCompany.Text;
            TbAddress.Text = FindJob.uc.lbAddress.Text;
            TbContact.Text= FindJob.uc.lbContact.Text;
            TbNameJob.Text=FindJob.uc.lbNameJob.Text;
            TbPositon.Text=FindJob.uc.lbNeedPosition.Text;
            TbRecruit.Text=FindJob.uc.lbRecruit.Text;
            TbSalary.Text=FindJob.uc.lbSalary.Text;
            TbTime.Text=FindJob.uc.lbTime.Text;
        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DescribeJob_Load(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            InformationUser cv = new InformationUser();
            cv.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
