using QuanLiCongDanThanhPho.Model;
using System.Drawing.Imaging;


namespace QuanLiCongDanThanhPho
{
    public static class HinhDaiDien
    {
        private static void DeleteDirectory(string folderPath, string fileName)
        {
            string fileNamePng = fileName + ".png";
            string fullPathPng = Path.Combine(folderPath, fileNamePng);

            string fileNameJpg = fileName + ".jpg";
            string fullPathJpg = Path.Combine(folderPath, fileNameJpg);

            if (File.Exists(fullPathPng))
            {
                File.Delete(fullPathPng);
            }
            if (File.Exists(fullPathJpg))
            {
                File.Delete(fullPathJpg);
            }

        }
        public static void SaveHinhDaiDien(string name, OpenFileDialog ofdHinhDaiDien, PictureBox ptcHinhDaiDien, string path)
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = string.Format(name);
            string folderPath = string.Format(System.IO.Path.Combine(sCurrentDirectory, path));
            string fullPath;
            DeleteDirectory(folderPath, fileName); //Xóa ảnh cũ
            if (ofdHinhDaiDien.FileName.Contains(".jpg"))
            {
                fileName += ".jpg";
                fullPath = Path.Combine(folderPath, fileName);
                ptcHinhDaiDien.Image.Save(fullPath, ImageFormat.Jpeg);
            }
            else
            {
                fileName += ".png";
                fullPath = Path.Combine(folderPath, fileName);
                ptcHinhDaiDien.Image.Save(fullPath, ImageFormat.Png);
            }
        }
        public static bool ThemHinhDaiDien(OpenFileDialog ofdHinhDaiDien, PictureBox ptcHinhDaiDien)
        {
            ofdHinhDaiDien.Filter = "PImage Files (*.jpg, *.png)|*.jpg;*.png";
            try
            {
                if (ofdHinhDaiDien.ShowDialog() == DialogResult.OK)
                {
                    ptcHinhDaiDien.Image = new Bitmap(ofdHinhDaiDien.FileName);
                }
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static void LayHinhDaiDien(string name, PictureBox ptcHinhDaiDien, string path)
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = string.Format(System.IO.Path.Combine(sCurrentDirectory, path));
            string imagePath = string.Format(@$"{folderPath}\{name}");
            string png = imagePath + ".png";
            string jpg = imagePath + ".jpg";
            Bitmap bitmap = null;

            if (File.Exists(png))
            {
                bitmap?.Dispose();
                ptcHinhDaiDien.Image?.Dispose();

                using (Bitmap tempImage = new Bitmap(png, true)) //Giúp k bị lỗi không thể truy cập file đang hoạt động khi xóa
                {
                    bitmap = new Bitmap(tempImage);
                    ptcHinhDaiDien.Image = bitmap;
                }
            }
            else if (File.Exists(jpg))
            {
                bitmap?.Dispose();
                ptcHinhDaiDien.Image?.Dispose();

                using (Bitmap tempImage = new Bitmap(jpg, true))
                {
                    bitmap = new Bitmap(tempImage);
                    ptcHinhDaiDien.Image = bitmap;
                }
            }
        }

    }
}
