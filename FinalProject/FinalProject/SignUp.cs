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
    public partial class SignUp : Form
    {
        SqlConnection conn = new
         SqlConnection(Properties.Settings.Default.ConnStr);
        public SignUp()
        {
            InitializeComponent();
            ptbEye.Visible = true;
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
        private bool Check()
        {
            if (panel1.Visible == true)     // candidates
            {
                foreach (UserAccount account in ReadSQL.Accounts())
                {
                    if (account.Gmail == tbGmail.Text)
                    {
                        MessageBox.Show("This gmail is exist");
                        return false;
                    }
                }
            }
            if (panel2.Visible == true)
            {
                foreach (Employers E in ReadSQL.Company())
                {
                    if (E.Gmail == tbGmail.Text)
                    {
                        MessageBox.Show("This gmail is exist");
                        return false;
                    }
                }
            }
            if (tbPassword.Text != tbReEnterPassword.Text)
            {
                MessageBox.Show("The Re-Password different the Password");
                return false;
            }
            //if (panel1.Visible == false && panel2.Visible == false)
            //{
            //    MessageBox.Show("dang ky tk");
            //    return false;
            //}
            return true;
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text.Length == 0)
            {
                panelInvalid1.Visible = true;
                return;
            }
            if (tbGmail.Text.Length == 0)
            {
                panelInvalid2.Visible = true;
                return;
            }
            if (tbPassword.Text.Length == 0)
            {
                panelInvalid3.Visible = true;
                return;
            }        
            if (tbReEnterPassword.Text.Length == 0)
            {
                panelInvalid4.Visible = true;
                return;
            }
            if (panel1.Visible == false && panel2.Visible == false)
            {
                MessageBox.Show("Please select a login type !!!");
                return;
            }
            if (Check() == true)
            {
                // đua du lieu vao database 
                string SQL;
                string name;
                if (panel1.Visible == true)
                {
                    name = "Candidates";
                }// CANDIDATES
                else
                {
                    name = "Employers";
                }

                SQL = string.Format($"INSERT INTO {name}" + "(Name,Gmail,Password) VALUES ('{0}','{1}','{2}')", tbUserName.Text, tbGmail.Text, tbPassword.Text);
                try
                {
                    // Ket noi
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                    { 
                        //MessageBox.Show("Successful!!!");
                        DialogResult result = MessageBox.Show("Successful!!!", "Confirm", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            this.Hide();
                            Login login = new Login();
                            login.ShowDialog();
                        }
                        else
                        {
                            this.Hide();
                            Login login = new Login();
                            login.ShowDialog();
                        }
                        
                    }
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
            else
            {
                return;
            }
        }

        private void ptbEye_Click(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '\0';
            ptbHidden.Visible = true;
            ptbEye.Visible = false;
        }

        private void ptbHidden_Click(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';
            ptbHidden.Visible = false;
            ptbEye.Visible = true;
        }

        private void lbConvertLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            LbCandidates.ForeColor = Color.FromArgb(33, 42, 57);
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            LbRecruiters.ForeColor = Color.FromArgb(33, 42, 57);
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            LbCandidates.ForeColor = Color.Transparent;
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            LbRecruiters.ForeColor = Color.Transparent;
        }

        private void lbConvertLogIn_MouseEnter(object sender, EventArgs e)
        {
            lbConvertLogIn.ForeColor = Color.FromArgb(33, 42, 57);
        }

        private void lbConvertLogIn_MouseLeave(object sender, EventArgs e)
        {
            lbConvertLogIn.ForeColor = Color.Transparent;
        }
    }
}
