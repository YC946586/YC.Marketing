using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using YC.Client.Entity;
using YC.Client.Entity.Gngl;
using YC.Client.Execute.UnityInjection;
using YC.Model;
using YC.RequestConver;
using YC.ViewModel;

namespace YC.ClientView
{
    public class Acceptance
    {
        public Acceptance()
        {
            try
            {
                InitMain();
                BootStrapper.Initialize();
                //查询出当前角色可以使用的所有功能
                LoginResultData.TheMainConfig = DataRequest<UcGnglEntity>.Addition(new UcGnglEntity());
                MainViewModel view = new MainViewModel();
                view.InitDefaultView(); //加载首页数据
                var dialog = ServiceProvider.Instance.Get<IModelDialog>("MainViewDlg");
                dialog.BindViewModel(view);
                //client.InitBase();
                dialog.ShowDialog(view.ExtendedOpenedEventHandler, view.ExtendedClosingEventHandler);
            }
            catch (Exception ex)
            {
                
                throw;
            }
           
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
