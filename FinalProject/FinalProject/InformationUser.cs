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
    public partial class InformationUser : Form
    {
        public InformationUser()
        {
            InitializeComponent();
        }

        private void btnAddImageUser_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    PtbImageUser.ImageLocation = imageLocation;
                }
            }
            catch(Exception) { 
            MessageBox.Show("An Error Occured","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateCV createCV = new CreateCV();
            createCV.ShowDialog();
        }
    }
}
