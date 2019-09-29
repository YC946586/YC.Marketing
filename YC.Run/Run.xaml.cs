using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace YC.Run
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class Run : Window
    {
        public Run()
        {
            InitializeComponent();

            InitMain();
            ClientView.MainView main=new ClientView.MainView();
          
            main.ShowDialog();
            Application.Current.Shutdown(0);
        }

        public   void InitMain()
        {
            //加载主题文件
            System.Windows.Application.Current.Resources.MergedDictionaries.Clear();
            System.Windows.Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri(
                    "pack://application:,,,/YC.Client.UI.Resources;component/themes/OverallStyle.xaml",
                    UriKind.RelativeOrAbsolute)
            });
            //基类里面还可以针对通用对象操作
            //base.InitMain();
            //初始化托盘
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Images"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Images");
            }      
        }
    }
}
