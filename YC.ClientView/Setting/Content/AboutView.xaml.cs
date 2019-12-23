using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace YC.ClientView.Setting.Content
{
    /// <summary>
    /// AboutView.xaml 的交互逻辑
    /// </summary>
    public partial class AboutView : UserControl
    {
        public AboutView()
        {
            InitializeComponent();
        }

        private void Hyperlink_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Hyperlink link = sender as Hyperlink;
                Process.Start(new ProcessStartInfo(link.NavigateUri.AbsoluteUri));
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
