using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using YC.Client.Entity;
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
            MainModel model = new MainModel
            {
                UserInfo = new LoginUserInfo()
                {
                    UserName = "洋葱",
                    UserIcon = "HaderIcon",
                }
            };
            var tabFun = LoginResultData.TheMainConfig.Where(s => s.GNLX == 1).OrderBy(s => s.JDPX).ToList();
            if (tabFun.Any())
            {
                tabFun.ForEach((ary) =>
                {
                    PageModule pageModel = new PageModule(ary.JDMC, ary.JDSX, ary.JDPX);
                    model.Modules.Add(pageModel);
                });
            }

            //初始化模块
            Open(model.Modules.First());
            MainGroups.Add(model);
            //Class1.getYHgl();
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
                var polymorphismAssbly =
                    Assembly.LoadFrom(AppDomain.CurrentDomain.BaseDirectory + "\\YC.ClientView.dll");
                if (string.IsNullOrEmpty(model.OpenSpace))
                {
                    RefreshCommon.SelectMenuGroup = Common.GetUserControl("YC.ClientView.DefaultViewPage");
                    return;
                }
            
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
