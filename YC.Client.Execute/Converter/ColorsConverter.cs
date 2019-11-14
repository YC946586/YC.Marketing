using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace YC.Client.Execute.Converter
{
    /// <summary>
    /// 颜色转换器
    /// </summary>
    public class ColorsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                switch (int.Parse(value.ToString()))
                {
                    case 0:
                        {
                            return "#56A2FB";
                        }
                    case 1:
                        {
                            return "#2AB9A5";
                        }
                    case 2:
                        {
                            return "#FF8066";
                        }
                    case 3:
                        {
                            return "#FFBA0A";
                        }
                    case 4:
                        {
                            return "#FE4A77";
                        }
                    case 5:
                        {
                            return "#FE4A77";
                        }
                    case 6:
                        {
                            return "#2EE555";
                        }
                 
                    //case 8:
                    //    {
                    //        break;
                    //    }
                    //case 9:
                    //    {
                    //        break;
                    //    }
                    default:
                        {
                            return "#2AB9A5";
                        }
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
