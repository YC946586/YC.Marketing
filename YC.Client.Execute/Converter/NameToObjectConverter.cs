using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace YC.Client.Execute.Converter
{
    /// <summary>
    /// 根据Name转化为资源文件
    /// 并缓存到当前域中
    /// </summary>
    public class NameToObjectConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                if (parameter != null)
                {
                    return null;
                }
                else
                {
                    if (value == null)
                    {
                        return null;
                    }
                    string imgName = value as string;
                    var resoures = Application.Current.FindResource(imgName);
                    return resoures;

                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
