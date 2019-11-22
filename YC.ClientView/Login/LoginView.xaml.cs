using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using GalaSoft.MvvmLight.Messaging;
using MaterialDesignThemes.Wpf;
using YC.Client.Execute.UnityInjection;
using YC.Client.Execute.UnityInjection.ViewDialog;

namespace YC.ClientView.Login
{
    /// <summary>
    /// LoginView.xaml 的交互逻辑
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }
    }

    /// <summary>
    /// 登录窗口
    /// </summary>
    public class LoginViewDlg : BaseViewDialog<LoginView>, IModelDialog
    {
        public override void BindViewModel<TViewModel>(TViewModel viewModel)
        {
            GetDialogWindow().DataContext = viewModel;
        }

        public override void Close()
        {
            GetDialogWindow().Close();
        }

        public override Task<bool> ShowDialog(DialogOpenedEventHandler openedEventHandler = null, DialogClosingEventHandler closingEventHandler = null)
        {
            GetDialogWindow().ShowDialog();
            return Task.FromResult(true);
        }

        public override void RegisterDefaultEvent()
        {
            GetDialogWindow().MouseDown += (sender, e) => { if (e.LeftButton == MouseButtonState.Pressed) { GetDialogWindow().DragMove(); } };

            Messenger.Default.Register<string>(GetDialogWindow(), "ApplicationHiding", new Action<string>((arg) =>
            {
                Close();
            }));
            
            Messenger.Default.Register<string>(GetDialogWindow(), "ApplicationShutdown", new Action<string>((arg) =>
            {
                Application.Current.Shutdown();
            }));
        }

        private Window GetDialogWindow()
        {
            return GetDialog() as Window;
        }
    }
}
