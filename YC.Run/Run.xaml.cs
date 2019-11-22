using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
            var clientAssbly = Assembly.LoadFrom(AppDomain.CurrentDomain.BaseDirectory + "\\YC.ClientView.dll");
            Activator.CreateInstance(clientAssbly.GetType("YC.ClientView.Acceptance"));
            if (Application.Current!=null)
            {
                Application.Current.Shutdown(0);
            }
           
        }

       
    }
}
