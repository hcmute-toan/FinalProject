using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
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
            ptbEye.Visible = true;
            this.KeyDown += new KeyEventHandler(Login_KeyDown);
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
                tbUserName.ForeColor = Color.Blue;
                panelInvalid1.Visible = false;

            }
            catch { }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbPassword.ForeColor = Color.Blue;
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

        public static int IdCompany;
       private void btnLogin_Click(object sender, EventArgs e)
        {
            if( tbUserName.Text.Length==0)
            {
                panelInvalid1.Visible = true;
                return;
            }
            if (tbPassword.Text.Length==0)
            {
                panelInvalid2.Visible = true;
                return;
            }
            if (panel1.Visible == false && panel2.Visible == false)
            {
                MessageBox.Show("Please select a login type !!!");
                return;
            }
            foreach (UserAccount account in ReadSQL.Accounts())
            {
                if(panel1.Visible==true && tbUserName.Text==account.UserName &&  tbPassword.Text==account.Password)
                {
                    this.Hide();
                    FindJob form1 = new FindJob();
                    form1.ShowDialog();
                    return;
                }
                
            }
            
            foreach(Employers E in ReadSQL.Company())
            {
                if (panel2.Visible == true && tbUserName.Text == E.UserName && tbPassword.Text == E.Password)
                {
                    IdCompany=E.Id;
                    this.Hide();
                    CreateJobs form1 = new CreateJobs();
                    form1.ShowDialog();
                    return;
                }
            }
            MessageBox.Show("Incorrect password or account!!!");
            return;
        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;           
        }

        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = true;
        }

        private void ptbHidden_Click(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';
            ptbHidden.Visible = false;
            ptbEye.Visible = true;
        }

        private void ptbEye_Click_1(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '\0';
            ptbHidden.Visible = true;
            ptbEye.Visible = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.FromArgb(0, 222, 0);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.FromArgb(0, 222, 195);
        }

     

        private void label4_MouseEnter_1(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(0, 222, 0);
        }

        private void label4_MouseLeave_1(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(0, 222, 195);
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
                MessageBox.Show("Enter vua duoc nhan !!!");
            }
        }
    }
}
