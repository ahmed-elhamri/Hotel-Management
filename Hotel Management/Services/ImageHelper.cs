using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Hotel_Management.Services
{
    public static class ImageHelper
    {
        private static readonly string ImageFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "RoomImages");
        private static readonly string DefaultImagePath = "Assets/coming-soon-photo.png";

        public static string SaveImageToFolder(string sourcePath)
        {
            if (string.IsNullOrEmpty(sourcePath)) return DefaultImagePath;

            try
            {
                
                if (!Directory.Exists(ImageFolderPath))
                {
                    Directory.CreateDirectory(ImageFolderPath);
                }

                
                string extension = Path.GetExtension(sourcePath);
                string uniqueFileName = $"{Guid.NewGuid()}{extension}";
                string destinationPath = Path.Combine(ImageFolderPath, uniqueFileName);

                
                File.Copy(sourcePath, destinationPath, true);

                
                return Path.Combine("Assets", "RoomImages", uniqueFileName);
            }
            catch (Exception)
            {
                return DefaultImagePath;
            }
        }

        public static BitmapImage LoadImage(string relativePath)
        {
            try
            {
                string fullPath;
                if (string.IsNullOrEmpty(relativePath))
                {
                    fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DefaultImagePath);
                }
                else
                {
                    fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                    if (!File.Exists(fullPath))
                    {
                        fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DefaultImagePath);
                    }
                }

                return new BitmapImage(new Uri(fullPath, UriKind.Absolute));
            }
            catch
            {
                
                return null;
            }
        }

        public static string GetDefaultImagePath()
        {
            return DefaultImagePath;
        }
    }
}

