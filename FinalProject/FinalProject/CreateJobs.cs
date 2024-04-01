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
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Net;
using System.IO;
using System.Globalization;
using System.Resources.Extensions;
using System.Web.UI.WebControls;
using System.Resources;
using System.Reflection;
namespace FinalProject
{
    public partial class CreateJobs : Form
    {
        SqlConnection conn = new
         SqlConnection(Properties.Settings.Default.ConnStr);
        public CreateJobs()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Jobs job = new Jobs();

            string SQL = string.Format("INSERT INTO Jobs (CompanyId,NameJob,PositionNeeded,CompanyName,Salary,Address,PostingTime,NumberOfRecruit,Contact) VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                Login.IdCompany, tbNameJob.Text, tbPositionNeeded.Text, tbCompany.Text, tbSlary.Text, CbAddressCrea.Text, DateTime.Now.ToString("dd/MM/yyyy"), tbRecruit.Text, tbContact.Text);
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Successful!!!");
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


        //private void btnAddImageLogoCompany_Click(object sender, EventArgs e)
        //{
        //    string imageLocation = "";
        //    try
        //    {
        //        OpenFileDialog dialog = new OpenFileDialog();
        //        dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
        //        if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //        {
        //            imageLocation = dialog.FileName;
        //                string resourceName = "YourLogo"; // Thay thế bằng tên bạn muốn

        //                // Đọc dữ liệu ảnh
        //                byte[] imageData = System.IO.File.ReadAllBytes(imageLocation);

        //                // Thêm dữ liệu ảnh dưới dạng resource (giả sử .NET 4.6+)
        //                Properties.Resources.ResourceManager.AddResource(resourceName, imageData);

        //                // Truy cập ảnh từ resource (tùy chọn)
        //                PtbImageLogoCompany.Image = Properties.Resources.YourLogo;

        //            }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }



        //private void btnAddImageLogoCompany_Click(object sender, EventArgs e)
        //{

        //    //string imageLocation = "";

        //    //    OpenFileDialog dialog = new OpenFileDialog();
        //    //    dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
        //    //    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    //    {
        //    //        imageLocation = dialog.FileName;
        //    //        PtbImageLogoCompany.ImageLocation = imageLocation;
        //    //    }
        //    //    // Tên tài nguyên bạn muốn gán cho ảnh
        //    //    string resourceName = "MyImage";

        //    //    // Thêm ảnh vào tài nguyên
        //    //    // In thông báo


        //    //    // Kiểm tra xem tệp ảnh tồn tại hay không
        //    //    if (!File.Exists(imageLocation))
        //    //    {
        //    //        Console.WriteLine("Image file not found!");
        //    //        return;
        //    //    }

        //    //    // Tạo một tài nguyên mới
        //    //    using (ResourceWriter writer = new ResourceWriter("Resources"))
        //    //    {
        //    //        // Đọc dữ liệu từ tệp ảnh
        //    //        byte[] imageBytes = File.ReadAllBytes(imageLocation);

        //    //        // Thêm ảnh vào tài nguyên với tên đã chỉ định
        //    //        writer.AddResource(resourceName, imageBytes);
        //    //    }
        //    //    Console.WriteLine("Image added to resources successfully!");

        //    //}

        //        string imageLocation = "";

        //        OpenFileDialog dialog = new OpenFileDialog();
        //        dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
        //        if (dialog.ShowDialog() == DialogResult.OK)
        //        {
        //            imageLocation = dialog.FileName;
        //            PtbImageLogoCompany.ImageLocation = imageLocation;
        //        }
        //        else
        //        {
        //            // Người dùng đã hủy chọn tệp, do đó không có gì cần phải làm
        //            return;
        //        }

        //        // Tên tài nguyên bạn muốn gán cho ảnh
        //        string resourceName = "MyImage";

        //    try
        //    {
        //        // Tạo một tài nguyên mới
        //        using (ResXResourceWriter writer = new ResXResourceWriter("Properties\\Resources.resx"))
        //        {
        //            // Đọc dữ liệu từ tệp ảnh
        //            byte[] imageBytes = File.ReadAllBytes(imageLocation);

        //            // Thêm ảnh vào tài nguyên với tên đã chỉ định
        //            writer.AddResource(resourceName, imageBytes);
        //        }

        //        MessageBox.Show("Image added to resources successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Failed to add image to resources: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    }


        //private void btnAddImageLogoCompany_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog dialog = new OpenFileDialog();
        //    dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
        //    if (dialog.ShowDialog() == DialogResult.OK)
        //    {
        //        string imageLocation = dialog.FileName;
        //        PtbImageLogoCompany.ImageLocation = imageLocation;

        //        // Tên tài nguyên bạn muốn gán cho ảnh
        //        string resourceName = "MyImage";

        //        try
        //        {
        //            // Tạo một tài nguyên mới
        //            using (ResXResourceWriter writer = new ResXResourceWriter("Properties\\Resources.resx"))
        //            {
        //                // Đọc dữ liệu từ tệp ảnh
        //                byte[] imageBytes = File.ReadAllBytes(imageLocation);

        //                // Thêm ảnh vào tài nguyên với tên đã chỉ định
        //                writer.AddResource(resourceName, imageBytes);
        //            }

        //            MessageBox.Show("Image added to resources successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Failed to add image to resources: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}
        //private void btnAddImageLogoCompany_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog dialog = new OpenFileDialog();
        //    dialog.Filter = "jpg files (*.jpg)|*.jpg| PNG files (*.png)|*.png| All Files (*.*)|*.*";
        //    if (dialog.ShowDialog() == DialogResult.OK)
        //    {
        //        string imageLocation = dialog.FileName;

        //        // Tên tài nguyên bạn muốn gán cho ảnh
        //        string resourceName = "MyImage";

        //        try
        //        {
        //            // Lấy thư mục project hiện tại (chứa file code)
        //            string projectPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        //            // Tạo đường dẫn đầy đủ đến file .resx (nằm trong thư mục Properties)
        //            string resourcePath = Path.Combine(projectPath, "D:\\WINDOW PROGRAMING\\666\\FinalProject\\FinalProject\\FinalProject\\Properties\\Resources.resx");

        //            // Tạo một tài nguyên mới
        //            ResXResourceWriter writer = new ResXResourceWriter(resourcePath);
                     
        //                    // Đọc dữ liệu từ tệp ảnh
        //                    byte[] imageBytes = File.ReadAllBytes(imageLocation);

        //                    // Thêm ảnh vào tài nguyên với tên đã chỉ định
        //                    writer.AddResource(resourceName, imageBytes);
                     

        //            MessageBox.Show("Image added to resources successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        catch (Exception ex)    
        //        {
        //            MessageBox.Show("Failed to add image to resources: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

        //private void btnAddImageLogoCompany_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog dialog = new OpenFileDialog();
        //    dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
        //    if (dialog.ShowDialog() == DialogResult.OK)
        //    {
        //        string imageLocation = dialog.FileName;
        //        PtbImageLogoCompany.ImageLocation = imageLocation;

        //        // Tên tài nguyên bạn muốn gán cho ảnh
        //        string resourceName = "MyImage";

        //        try
        //        {
        //            // Lấy đường dẫn thư mục gốc của ứng dụng
        //            string appDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        //            // Xây dựng đường dẫn đến tệp tài nguyên
        //            string resourceFilePath = Path.Combine(appDirectory, "Properties", "Resources.rex");

        //            // Tạo một tài nguyên mới
        //            using (ResXResourceWriter writer = new ResXResourceWriter(resourceFilePath))
        //            {
        //                // Đọc dữ liệu từ tệp ảnh
        //                byte[] imageBytes = File.ReadAllBytes(imageLocation);

        //                // Thêm ảnh vào tài nguyên với tên đã chỉ định
        //                writer.AddResource(resourceName, imageBytes);
        //            }

        //            MessageBox.Show("Image added to resources successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Failed to add image to resources: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}
    }

    }


    

    //try
    //{
    //    OpenFileDialog dialog = new OpenFileDialog();
    //    dialog.Filter = "Image files (*.jpg, *.png)|*.jpg;*.png";

    //    if (dialog.ShowDialog() == DialogResult.OK)
    //    {
    //        // Lưu ảnh vào project
    //        string fileName = Path.GetFileName(dialog.FileName);
    //        Properties.Resources.ResourceManager(fileName, dialog.FileName);

    //        // Truy cập ảnh từ resource
    //        PtbImageLogoCompany.Image = Properties.Resources.logo;
    //    }
    //}
    //catch (Exception ex)
    //{
    //    MessageBox.Show("Lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //}

    //try
    //{
    //    OpenFileDialog dialog = new OpenFileDialog();
    //    dialog.Filter = "Image files (*.jpg, *.png)|*.jpg;*.png";

    //    if (dialog.ShowDialog() == DialogResult.OK)
    //    {
    //        string fileName = Path.GetFileName(dialog.FileName);


    //        // Read image data
    //        byte[] imageData = System.IO.File.ReadAllBytes(dialog.FileName);

    //        // Add image data as a resource
    //        Properties.Resources.ResourceManager.AddResource(resourceName, imageData);

    //        // Access the image from resource (optional)
    //        PtbImage.Image = Properties.Resources.YourImageName;
    //    }
    //}
    //catch (Exception ex)
    //{
    //    MessageBox.Show("Lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //}




