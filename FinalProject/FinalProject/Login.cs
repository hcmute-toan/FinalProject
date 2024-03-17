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
    public partial class Login : Form
    {   
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbUserName.ForeColor = Color.Green;
                panelInvalid1.Visible = false;

            }
            catch { }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbPassword.ForeColor = Color.Green;
                panelInvalid2.Visible = false;

            }
            catch { }
        }

        private void tbUserName_Click(object sender, EventArgs e)
        {
            tbUserName.SelectAll();
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            tbPassword.SelectAll();
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor= Color.Black;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbUserName.PlaceholderText== "Enter Your Name"|| tbUserName.Text.Length==0)
            {
                panelInvalid1.Visible = true;
                return;
            }
            if (tbPassword.PlaceholderText == "Enter Password"||tbPassword.Text.Length==0)
            {
                panelInvalid2.Visible = true;
                return;
            }
        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;           
        }

        //private void guna2CirclePictureBox4_MouseHover(object sender, EventArgs e)
        //{
        //    guna2CirclePictureBox4.Width *= 0.5;
        //}
    }
}
