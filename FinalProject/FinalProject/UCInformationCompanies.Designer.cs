using System.Windows.Forms;

namespace FinalProject
{
    partial class UCInformationCompanies
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public void OnClick()
        {
            // Xử lý sự kiện click
            MessageBox.Show("User Control đã được click!");

        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCInformationCompanies));
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbNameCompany = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbNameJob = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbNeedPosition = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbRecruit = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbContact = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSalary = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(99, 102);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 2;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lbNameCompany
            // 
            this.lbNameCompany.AutoSize = true;
            this.lbNameCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameCompany.Location = new System.Drawing.Point(5, 5);
            this.lbNameCompany.Margin = new System.Windows.Forms.Padding(5);
            this.lbNameCompany.Name = "lbNameCompany";
            this.lbNameCompany.Size = new System.Drawing.Size(94, 20);
            this.lbNameCompany.TabIndex = 3;
            this.lbNameCompany.Text = "Tuyensansi";
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(142, 5);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(18, 20);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 4;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // lbNameJob
            // 
            this.lbNameJob.AutoSize = true;
            this.lbNameJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameJob.Location = new System.Drawing.Point(141, 9);
            this.lbNameJob.Name = "lbNameJob";
            this.lbNameJob.Size = new System.Drawing.Size(126, 20);
            this.lbNameJob.TabIndex = 5;
            this.lbNameJob.Text = "RÚT HẦM CẦU";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(142, 61);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(110, 16);
            this.lbAddress.TabIndex = 6;
            this.lbAddress.Text = "TP HỒ CHÍ MINH";
            // 
            // lbNeedPosition
            // 
            this.lbNeedPosition.AutoSize = true;
            this.lbNeedPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNeedPosition.Location = new System.Drawing.Point(403, 10);
            this.lbNeedPosition.Name = "lbNeedPosition";
            this.lbNeedPosition.Size = new System.Drawing.Size(162, 18);
            this.lbNeedPosition.TabIndex = 7;
            this.lbNeedPosition.Text = "Tốt nghiệp cấp 3 trở lên\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(644, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số lượng cần tuyển :\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(643, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Đăng vào :\r\n";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbRecruit
            // 
            this.lbRecruit.AutoSize = true;
            this.lbRecruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecruit.Location = new System.Drawing.Point(792, 68);
            this.lbRecruit.Name = "lbRecruit";
            this.lbRecruit.Size = new System.Drawing.Size(16, 18);
            this.lbRecruit.TabIndex = 10;
            this.lbRecruit.Text = "0";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(728, 108);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(80, 18);
            this.lbTime.TabIndex = 11;
            this.lbTime.Text = "22/12/2023";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(768, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(40, 38);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 12;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Contact :";
            // 
            // lbContact
            // 
            this.lbContact.AutoSize = true;
            this.lbContact.Location = new System.Drawing.Point(403, 108);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(217, 16);
            this.lbContact.TabIndex = 14;
            this.lbContact.Text = "vancongtoan09102004@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Salary :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Location = new System.Drawing.Point(403, 61);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(83, 16);
            this.lbSalary.TabIndex = 16;
            this.lbSalary.Text = "thuong luong";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 15);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Request :";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lbNameCompany);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox2);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 108);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(172, 34);
            this.guna2Panel1.TabIndex = 19;
            // 
            // UCInformationCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbRecruit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbNeedPosition);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbNameJob);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Name = "UCInformationCompanies";
            this.Size = new System.Drawing.Size(811, 163);
            this.Load += new System.EventHandler(this.UCInformationCompanies_Load);
            this.Click += new System.EventHandler(this.UCInformationCompanies_Click);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        public System.Windows.Forms.Label lbNameCompany;
        public Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        public System.Windows.Forms.Label lbNameJob;
        public System.Windows.Forms.Label lbAddress;
        public System.Windows.Forms.Label lbNeedPosition;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lbRecruit;
        public System.Windows.Forms.Label lbTime;
        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbContact;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
