using System;
using System.Globalization;
using System.Windows.Data;

namespace YC.Client.Execute.Converter
{
    /// <summary>
    /// 0/1 是否转换器
    /// </summary>
    public class FlagConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && int.TryParse(value.ToString(), out int result))
            {
                if (result.Equals(0))
                    return  true;
                else
                    return  false;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var data = (bool)value;
            if (data)
            {
                return 0;
            }
            return 1;
        }
    }
}
