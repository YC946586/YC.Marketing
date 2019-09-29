using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using YC.Model;

namespace YC.ViewModel
{
   public  class MainViewModel: ViewModelBase
    {
        public MainViewModel()
        {
            MainGroups=new ObservableCollection<MainModel>();

            MainGroups.Add(new MainModel()
            {
                UserInfo = new LoginUserInfo()
                {
                    UserName = "测试"
                },
            });
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
    }
}
