using System;
using System.Windows;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using YC.Client.Entity;
using YC.Client.Entity.Gngl;
using YC.Client.Execute.UnityInjection;
using YC.Client.Execute.UnityInjection.ViewDialog.CoreLib;
using YC.RequestConver;

namespace YC.ViewModel.Login
{
    public class LoginViewModel : BaseHostDialogOperation
    {
        #region 用户名/密码

        private string _Report;
        private string userName = string.Empty;
        private string passWord = string.Empty;
        private bool _UserChecked;
        private string _SkinName;

        /// <summary>
        /// 皮肤样式
        /// </summary>
        public string SkinName
        {
            get { return _SkinName; }
        }

        /// <summary>
        /// 进度报告
        /// </summary>
        public string Report
        {
            get { return _Report; }
            set { _Report = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 记住密码
        /// </summary>
        public bool UserChecked
        {
            get { return _UserChecked; }
            set { _UserChecked = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password
        {
            get { return passWord; }
            set { passWord = value; RaisePropertyChanged(); }
        }

     

        #endregion
 

        #region 命令(Binding Command)

        private RelayCommand _signCommand;

        public RelayCommand SignCommand
        {
            get
            {
                if (_signCommand == null)
                {
                    _signCommand = new RelayCommand(() => Login());
                }
                return _signCommand;
            }
        }

        private RelayCommand _exitCommand;

        public RelayCommand ExitCommand
        {
            get
            {
                if (_exitCommand == null)
                {
                    _exitCommand = new RelayCommand(() => ApplicationShutdown());
                }
                return _exitCommand;
            }
        }

        #endregion
        #region Login/Exit

        /// <summary>
        /// 登陆系统
        /// </summary>
        private void Login()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password))
                {         
                    this.Report = "正在验证登录 . . .";
                    //查询出当前角色可以使用的所有功能
                    LoginResultData.TheMainConfig = DataRequest<UcGnglEntity>.Addition(new UcGnglEntity());
                    MainViewModel model = new MainViewModel();
                    model.InitDefaultView();
                    var dialog = ServiceProvider.Instance.Get<IModelDialog>("MainViewDlg");
                    dialog.BindViewModel(model);
                    Messenger.Default.Send(string.Empty, "ApplicationHiding");
                    dialog.ShowDialog();
                    ApplicationShutdown();
                }
                else
                {
                    MessageBox.Show("请输入关键字");
                }
            }
            catch (Exception )
            {
                this.Report = "系统出现故障,请联系管理员处理";

            }    
        }

        /// <summary>
        /// 关闭系统
        /// </summary>
        private void ApplicationShutdown()
        {
            Messenger.Default.Send("", "ApplicationShutdown");
        }

        #endregion


        #region 记住密码

        /// <summary>
        /// 读取本地配置信息
        /// </summary>
        public void ReadConfigInfo()
        {
            //string cfgINI = AppDomain.CurrentDomain.BaseDirectory + Tool.Help.SerivceFiguration.INI_CFG;
            //if (File.Exists(cfgINI))
            //{
            //    IniFile ini = new IniFile(cfgINI);
            //    UserName = ini.IniReadValue("Login", "User");
            //    Password = ini.IniReadValue("Login", "Password");
            //    UserChecked = ini.IniReadValue("Login", "SaveInfo") == "Y";
            //    _SkinName = ini.IniReadValue("Skin", "Skin");
            //}
        }

        /// <summary>
        /// 保存登录信息
        /// </summary>
        private void SaveLoginInfo()
        {
            ////文件夹路径
            //string strPath = AppDomain.CurrentDomain.BaseDirectory + @"config";

            //if (!File.Exists(strPath))//判断文件夹是否存在
            //{
            //    Directory.CreateDirectory(strPath);
            //    string cfgINI = AppDomain.CurrentDomain.BaseDirectory + Tool.Help.SerivceFiguration.INI_CFG;
            //    if (!File.Exists(cfgINI))//判断文件是否存在
            //    {
            //        File.Create(cfgINI).Close();
            //    }
            //    IniFile ini = new IniFile(cfgINI);
            //    ini.IniWriteValue("Login", "User", UserName);
            //    ini.IniWriteValue("Login", "Password", Password);
            //    ini.IniWriteValue("Login", "SaveInfo", UserChecked ? "Y" : "N");
            //}

        }
        #endregion
    }
}
