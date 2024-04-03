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
    public partial class AcceptCV : Form
    {

        public AcceptCV()
        {
            InitializeComponent();
            lblName.Text = AcceptCVs.cvtmp.Name;
            lblAddress.Text = AcceptCVs.cvtmp.Address;
            lblGender.Text = AcceptCVs.cvtmp.Gender;
            lblDateOfBirth.Text = AcceptCVs.cvtmp.DateOfBirth;
            lblWorkExperience.Text = AcceptCVs.cvtmp.WorkExperience;
            lblEducation.Text = AcceptCVs.cvtmp.EducationAndCertifications;
            lblProfessional.Text = AcceptCVs.cvtmp.ProfessionalSkills;
            lblGoalsAtWork.Text = AcceptCVs.cvtmp.GoalAtWork;


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            int Status = 1; // CV đã được chấp nhận (CV has been accepted)
            string connectionString = "Data Source = TWELVE-T\\SQLEXPRESS; Initial Catalog = ManagerJobs; Integrated Security = True";

            using (SqlConnection connection = new SqlConnection(connectionString))

                try
                {

                    {
                        connection.Open();

                        // Tạo truy vấn có tham số
                        string SQL = "UPDATE JobApplication SET Status = @Status WHERE UserId = @UserId AND JobId = @JobId AND CompanyId = @CompanyId";

                        // Tạo một SqlCommand object
                        SqlCommand command = new SqlCommand(SQL, connection);

                        // Thêm tham số với giá trị
                        command.Parameters.AddWithValue("@Status", Status);
                        command.Parameters.AddWithValue("@UserId", AcceptCVs._idUser);
                        command.Parameters.AddWithValue("@JobId", CreateJobs._idJob);
                        command.Parameters.AddWithValue("@CompanyId", Login.IdCompany);

                        // Thực thi truy vấn cập nhật
                        command.ExecuteNonQuery();

                        // Hiển thị thông báo thành công (tùy chọn)
                        MessageBox.Show("Cập nhật thành công!");
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi cho người dùng
                    MessageBox.Show("Cập nhật thất bại: " + ex.Message);

                    // Ghi nhật ký chi tiết lỗi đầy đủ để gỡ lỗi (tùy chọn)
                    Console.WriteLine("Chi tiết lỗi đầy đủ: " + ex.ToString());
                }
                finally
                {
                    // Đóng kết nối
                    connection.Close(); // Sử dụng connection ở đây
                }

        }
    }
}
