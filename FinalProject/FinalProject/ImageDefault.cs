using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public static class ImageDefault
    {
        public static string filePath = @"D:\logo1.png";
        public static System.Drawing.Image image = System.Drawing.Image.FromFile(filePath);
        public static byte[] ImageToByteArray(System.Drawing.Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
    }
}
