using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using YC.Client.Execute.Commons;
using YC.Client.Execute.UnityInjection;
using YC.Client.Execute.UnityInjection.ViewDialog.CoreLib;
using YC.Model;
using YC.Model.IndexModel;

namespace YC.ViewModel
{
    public class MainViewModel : BaseHostDialogOperation
    {
        #region  属性 命令
        private ObservableCollection<MainModel> _mainGroups;

        /// <summary>
        /// 界面显示数据
        /// </summary>
        public ObservableCollection<MainModel> MainGroups
        {
            get { return _mainGroups; }
            set
            {
                _mainGroups = value;
                RaisePropertyChanged();
            }
        }

        private RelayCommand<PageModule> _OpenCommand;


        /// <summary>
        /// 打开模块
        /// </summary>
        public RelayCommand<PageModule> OpenCommand
        {
            get
            {
                if (_OpenCommand == null)
                {
                    _OpenCommand = new RelayCommand<PageModule>(Open);
                }
                return _OpenCommand;
            }
            set { _OpenCommand = value; }
        }
        #endregion
        /// <summary>
        /// 初始化首页
        /// </summary>
        public void InitDefaultView()
        {
            MainGroups = new ObservableCollection<MainModel>();
            MainModel model = new MainModel();
            model.UserInfo = new LoginUserInfo()
            {
                UserName = "测试",
                UserIcon = "HaderIcon",
            };
            int page = 0;
            for (int i = 0; i < 5; i++)
            {
                page++;
                PageModule pageModel = new PageModule("测试我" + i, "主窗体图标", "YC.ClientView.Workbench.WorkbenchViewDog", page);
                model.Modules.Add(pageModel);
            }
            RefreshCommon.IndexName = model.Modules.First().FunName;
            MainGroups.Add(model);
            GC.Collect();
        }



        /// <summary>
        /// 打开模块
        /// </summary>
        /// <param name="model"></param>
        private void Open(PageModule model)
        {
            try
            {
                //给静态属性赋值
                RefreshCommon.IndexName = model.FunName;
                var polymorphismAssbly = Assembly.LoadFrom(AppDomain.CurrentDomain.BaseDirectory + "\\YC.ClientView.dll");
                var log = polymorphismAssbly.CreateInstance(model.OpenSpace) is IModel;
                if (log)
                {
                    var dialog = polymorphismAssbly.CreateInstance(model.OpenSpace) as IModel;
                    dialog?.BindDefaultModel();
                    if (dialog != null) RefreshCommon.SelectMenuGroup = dialog.GetView();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                GC.Collect();
            }
        }

       
    }
}
