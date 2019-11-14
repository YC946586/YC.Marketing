using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using LiveCharts;
using YC.Model.IndexModel;

namespace YC.Model.Workbench
{
    public class WorkbenchModel : ViewModelBase
    {
        #region 统计图
        /// <summary>
        /// 折线图
        /// </summary>
        public SeriesCollection SeriesCollection { get; set; }


        public string[] CharName { get; set; }

        public Func<double, string> Formatter { get; set; }
        #endregion


        private ObservableCollection<KhDataModel> _listKhData = new ObservableCollection<KhDataModel>();

        /// <summary>
        /// 客户数据
        /// </summary>
        public ObservableCollection<KhDataModel> ListKhData
        {
            get { return _listKhData; }
            set
            {
                _listKhData = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<PageModule> _listFun = new ObservableCollection<PageModule>();

        /// <summary>
        /// 常用功能
        /// </summary>
        public ObservableCollection<PageModule> ListFun
        {
            get { return _listFun; }
            set
            {
                _listFun = value;
                RaisePropertyChanged();
            }
        }
        private ObservableCollection<TodoModel> _listTodo = new ObservableCollection<TodoModel>();

        /// <summary>
        ///待办事项
        /// </summary>
        public ObservableCollection<TodoModel> ListTodo
        {
            get { return _listTodo; }
            set
            {
                _listTodo = value;
                RaisePropertyChanged();
            }
        }


        private ObservableCollection<FuntionsModel> _listbroadcast = new ObservableCollection<FuntionsModel>();

        /// <summary>
        /// 最新功能 有赞神厨
        /// </summary>
        public ObservableCollection<FuntionsModel> Listbroadcast
        {
            get { return _listbroadcast; }
            set
            {
                _listbroadcast = value;
                RaisePropertyChanged();
            }
        }

    }


}
