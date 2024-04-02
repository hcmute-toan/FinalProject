using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net;
using System.IO;
using System.Globalization;
using System.Resources.Extensions;
using System.Web.UI.WebControls;
using System.Resources;
using System.Reflection;
using System.Data.SqlClient;
using System.Net.Mime;
using Image = System.Drawing.Image;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
            //AdDuLieu();


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
        //            string resourcePath = Path.Combine(projectPath, "D:\\WINDOW PROGRAMING\\666\\FinalProject\\FinalProject\\FinalProject\\Properties\\");

        //            // Tạo một tài nguyên mới
        //            ResXResourceWriter writer = new ResXResourceWriter(resourcePath);

        //            // Đọc dữ liệu từ tệp ảnh
        //            byte[] imageBytes = File.ReadAllBytes(imageLocation);

        //            // Thêm ảnh vào tài nguyên với tên đã chỉ định
        //            writer.AddResource(resourceName, imageBytes);


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
        //    dialog.Filter = "PNG files (*.png)|*.png|All Files (*.*)|*.*";
        //    if (dialog.ShowDialog() == DialogResult.OK)
        //    {
        //        string imageLocation = dialog.FileName;

        //        // Kiểm tra xem tệp đã chọn có phải là tệp PNG không
        //        if (Path.GetExtension(imageLocation).Equals(".png", StringComparison.OrdinalIgnoreCase))
        //        {
        //            // Tên tài nguyên bạn muốn gán cho ảnh
        //            string resourceName = "MyImage";

        //            try
        //            {
        //                // Lấy thư mục project hiện tại (chứa file code)
        //                string projectPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        //                // Tạo đường dẫn đầy đủ đến file .resx (nằm trong thư mục Properties)
        //                string resourceFilePath = Path.Combine(projectPath, "Properties", "D:\\WINDOW PROGRAMING\\666\\FinalProject\\FinalProject\\FinalProject\\Resources");

        //                // Tạo một tài nguyên mới
        //                using (ResXResourceWriter writer = new ResXResourceWriter(resourceFilePath))
        //                {
        //                    // Đọc dữ liệu từ tệp ảnh PNG
        //                    byte[] imageBytes = File.ReadAllBytes(imageLocation);

        //                    // Thêm ảnh vào tài nguyên với tên đã chỉ định
        //                    writer.AddResource(resourceName, imageBytes);
        //                }

        //                MessageBox.Show("Image added to resources successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Failed to add image to resources: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Please select a PNG file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

        //private void btnAddImageLogoCompany_Click(object sender, EventArgs e)
        //{
        //    // Improved file selection experience
        //    using (OpenFileDialog dialog = new OpenFileDialog())
        //    {
        //        dialog.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All Files (*.*)|*.*";
        //        dialog.Title = "Select Company Logo Image"; // Optional: Set a clear dialog title

        //        if (dialog.ShowDialog() == DialogResult.OK)
        //        {
        //            string imageLocation = dialog.FileName;

        //            // Validate image extension (more comprehensive)
        //            if (!ValidateImageExtension(imageLocation))
        //            {
        //                MessageBox.Show("Please select a valid image file (PNG, JPG, or JPEG).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return;
        //            }

        //            // Determine target folder based on user preference (consider flexibility)
        //            string targetFolder = "D:\\WINDOW PROGRAMING\\666\\FinalProject\\FinalProject\\FinalProject\\Resources" ; // Call a function to get the target folder path

        //            // Create the target folder if it doesn't exist
        //            if (!Directory.Exists(targetFolder))
        //            {
        //                Directory.CreateDirectory(targetFolder);
        //            }

        //            // Generate a unique filename (optional, but recommended for clarity)
        //            string newFilename = GenerateUniqueFilename(targetFolder, Path.GetExtension(imageLocation));

        //            try
        //            {
        //                // Copy the image to the target folder with the new filename
        //                File.Copy(imageLocation, Path.Combine(targetFolder, newFilename));

        //                MessageBox.Show("Image saved successfully to " + targetFolder + ".", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Failed to save image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //}
        //private bool ValidateImageExtension(string fileName)
        //{
        //    string extension = Path.GetExtension(fileName).ToLower();
        //    return extension == ".png" || extension == ".jpg" || extension == ".jpeg";
        //}

        //// Function to get the target folder path (implementation depends on your preference)
        //private string GetTargetFolder()
        //{
        //    // Option 1: Prompt the user for a specific folder
        //    // string targetFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "CompanyLogos");
        //    // MessageBox.Show("Please select a folder to save the company logo image:", "Select Folder", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //    // if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        //    // {
        //    //     targetFolder = folderBrowserDialog.SelectedPath;
        //    // }

        //    // Option 2: Use a pre-defined folder
        //    string targetFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "CompanyLogos");

        //    // Option 3: Other approaches based on your application logic

        //    return targetFolder;
        //}

        //// Function to generate a unique filename (optional, but recommended)
        //private string GenerateUniqueFilename(string folderPath, string extension)
        //{
        //    string baseFilename = "CompanyLogo";
        //    string filename = baseFilename + extension;
        //    int counter = 1;

        //    while (File.Exists(Path.Combine(folderPath, filename)))
        //    {
        //        counter++;
        //        filename = baseFilename + counter + extension;
        //    }

        //    return filename;
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

    

        //byte[] ImageToByteArray123(Image img)
        //{
        //    MemoryStream m = new MemoryStream();
        //    img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
        //    return m.ToArray();
        //}

        private void btnAddImageLogoCompany_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                PtbImageLogoCompany.Image = Image.FromFile(open.FileName);
                MessageBox.Show("Successful!!!" + open);
                this.Text = open.FileName;
            }
        }

        //private void AdDuLieu()
        //{ 
      

        //    Jobs job = new Jobs();

        //    //string SQL = string.Format("INSERT INTO Jobs (CompanyId,NameJob,PositionNeeded,CompanyName,Salary,Address,PostingTime,NumberOfRecruit,Contact,NamePic, Pic) VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}', '{9}', '{10}')",
        //    //    Login.IdCompany, tbNameJob.Text, tbPositionNeeded.Text, tbCompany.Text, tbSlary.Text, CbAddressCrea.Text, DateTime.Now.ToString("dd/MM/yyyy"), tbRecruit.Text, tbContact.Text,tbCompany.Text , b);
        //    try
        //    {
        //        // Ket noi
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand(SQL, conn);
        //        if (cmd.ExecuteNonQuery() > 0)
        //            MessageBox.Show("Successful!!!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Fail!!!" + ex);
        //    }
        //    finally
        //    {
        //        conn.Close();
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




