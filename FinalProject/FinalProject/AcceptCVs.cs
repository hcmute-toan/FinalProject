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
    public partial class AcceptCVs : Form
    {
        public static CV cvtmp;
        public static int _idUser;
        public AcceptCVs()
        {
            InitializeComponent();
            foreach (JobApplication japp in ReadSQL.Jobapplication())
            {
                if (Login.IdCompany == japp.IdCompany)
                {
                    if (CreateJobs._idJob == japp.IdJob)
                    {
                        foreach (CV cv in ReadSQL.Cvs())
                        {
                            UCInformationCV uc2 = new UCInformationCV();
                            if (japp.IdUser == cv.Id)
                            {
                                _idUser = cv.Id;
                                uc2.lbName.Text = cv.Name;
                                uc2.lbAge.Text = cv.DateOfBirth;
                                uc2.lbGender.Text = cv.Gender;
                                uc2.lbAddress.Text = cv.Address;
                                uc2.lbSkills.Text = cv.ProfessionalSkills;
                                uc2.lbExperience.Text = cv.WorkExperience;

                                uc2.TopLevel = false;
                                //this.Controls.Add(uc2);
                                flAcceptCVs.Controls.Add(uc2);
                                uc2.Show();
                                uc2.Click += (sender, e) =>
                                {
                                    cvtmp = cv;
                                    AcceptCV acceptCV = new AcceptCV();
                                    acceptCV.ShowDialog();


                                };
                            }



                        }
                    }
                }


            }
        }

        private void flAcceptCVs_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
