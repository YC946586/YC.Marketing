using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using YC.Client.Execute.UnityInjection.ViewDialog.CoreLib;
using YC.Model;
using YC.Model.IndexModel;

namespace YC.ViewModel
{
   public  class MainViewModel: BaseHostDialogOperation
    {
        public MainViewModel()
        {
            MainGroups = new ObservableCollection<MainModel>();
         

            MainModel model = new MainModel();
            model.UserInfo = new LoginUserInfo()
            {
                UserName = "测试",
                UserIcon = "HaderIcon",
            };

            for (int i = 0; i < 5; i++)
            {
                PageModule page=new PageModule("测试我"+i, "主窗体图标", "");
                model.Modules.Add(page);
            }
            MainGroups.Add(model);
        }
        private ObservableCollection<MainModel> _mainGroups;

        /// <summary>
        /// 界面显示数据
        /// </summary>
        public ObservableCollection<MainModel> MainGroups
        {
            get { return _mainGroups; }
            set {
                _mainGroups = value;
                RaisePropertyChanged(); }
        }

        /// <summary>
        /// 初始化首页
        /// </summary>
        public void InitDefaultView()
        {
            
        }
    }
}
