using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using YC.Client.Execute.UnityInjection;
using YC.ViewModel;

namespace YC.ClientView
{
    public class Acceptance
    {
        public Acceptance()
        {
            InitMain();
            BootStrapper.Initialize();
            MainViewModel view = new MainViewModel();
            view.InitDefaultView(); //加载首页数据
            var Dialog = ServiceProvider.Instance.Get<IModelDialog>("MainViewDlg");
            Dialog.BindViewModel(view);
            //client.InitBase();
            Dialog.ShowDialog(view.ExtendedOpenedEventHandler, view.ExtendedClosingEventHandler);  
        }
        /// <summary>
        /// 加载资源文件
        /// </summary>
        private void InitMain()
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
