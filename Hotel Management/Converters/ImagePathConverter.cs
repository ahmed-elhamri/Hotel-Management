using System;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using System.Globalization;

namespace Hotel_Management.Converters
{
    public class ImagePathConverter : IValueConverter
    {
        private readonly string _defaultImagePath;

        public ImagePathConverter()
        {
            _defaultImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "default_room.png");
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                string imagePath;
                if (value is string path && !string.IsNullOrEmpty(path))
                {
                    imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "Rooms", path);
                    if (!File.Exists(imagePath))
                    {
                        imagePath = _defaultImagePath;
                    }
                }
                else
                {
                    imagePath = _defaultImagePath;
                }

                var image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = new Uri(imagePath);
                image.EndInit();
                return image;
            }
            catch (Exception)
            {
                
                return new BitmapImage(new Uri(_defaultImagePath));
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}