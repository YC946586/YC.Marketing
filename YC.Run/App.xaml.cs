using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace YC.Run
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            //UI线程未捕获异常处理事件
            this.DispatcherUnhandledException += (sender, args) =>
            {
                WriteErrorLog(args.Exception.Message);
            };
            //Task线程未捕获异常处理事件
            TaskScheduler.UnobservedTaskException += (sender, args) =>
            {
                WriteErrorLog(args.Exception.Message);
            };

            //
            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                if (args.IsTerminating)
                {
                    System.Windows.MessageBox.Show("我们很抱歉,当前应用程序遇到一些问题,公共语言运行时已经终止,请重新启动程序,如果还遇到此情况,请联系我们。 ", "应用程序即将终止",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            };
        }

        /// <summary>
        /// 日志记录
        /// </summary>
        /// <param name="args"></param>
        private void WriteErrorLog(string args)
        {
            try
            {
                string fileName = DateTime.Now.ToString("yyyy年MM月dd日");
                //文件夹路径
                string strPath = AppDomain.CurrentDomain.BaseDirectory + @"Temp\ErrorLog\" + fileName + ".ini";


                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"Temp\ErrorLog"))//判断文件夹是否存在
                {
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"Temp\ErrorLog");
                    if (!File.Exists(strPath))//判断文件是否存在
                    {
                        File.Create(strPath).Close();
                    }
                }
                List<string> listConfig = new List<string>();
                listConfig.Add(DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss"));
                listConfig.Add("\n");
                listConfig.Add(args);
                listConfig.Add("\n\r");
                File.AppendAllLines(strPath, listConfig.ToArray(), Encoding.UTF8);//写入错误配置
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
