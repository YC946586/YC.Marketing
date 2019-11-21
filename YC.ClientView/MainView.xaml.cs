using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using GalaSoft.MvvmLight.Messaging;
using MaterialDesignThemes.Wpf;
using YC.Client.Execute.UnityInjection;
using YC.Client.Execute.UnityInjection.ViewDialog;

namespace YC.ClientView
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
        }  
    }

    /// <summary>
    /// 首页
    /// </summary>
    public class MainViewDlg : BaseViewDialog<MainView>, IModelDialog
    {
        public override void BindViewModel<TViewModel>(TViewModel viewModel)
        {
            GetDialogWindow().DataContext = viewModel;
        }

        public override void Close()
        {
            GetDialogWindow().Close();
        }

        public override Task<bool> ShowDialog(DialogOpenedEventHandler openedEventHandler = null,
            DialogClosingEventHandler closingEventHandler = null)
        {
            GetDialogWindow().ShowDialog();
            return Task.FromResult(true);
        }

        public override void RegisterDefaultEvent()
        {
            GetDialogWindow().MouseDown += (sender, e) =>
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    GetDialogWindow().DragMove();
                }
            };
            Messenger.Default.Register<string>(GetDialogWindow(), "MainExit", new Action<string>( (msg) =>
            {
                /* if (await Message.Msg.Question(msg))*/
                this.Close();
            }));
            
        }

        private Window GetDialogWindow()
        {
            return GetDialog() as Window;
        }
    }
}
