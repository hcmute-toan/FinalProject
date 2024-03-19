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
            UCInformationCompanies uCInformationCompanies = new UCInformationCompanies();
            this.Controls.Add(uCInformationCompanies);
            flowLayoutjobs.Controls.Add(uCInformationCompanies);




        }
       

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutjobs_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
