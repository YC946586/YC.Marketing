using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using YC.Model.IndexModel;

namespace YC.Model.Workbench
{
    public class WorkbenchModel : ViewModelBase
    {

        private string a;
        private string b;

        /// <summary>
        /// 标题
        /// </summary>
        public string A
        {
            get { return a; }
            set { a = value; }
        }

        /// <summary>
        /// 窗口内容
        /// </summary>
        public string B
        {
            get { return b; }
            set { b = value; }
        }

        private ObservableCollection<PageModule> _listFun = new ObservableCollection<PageModule>();

        /// <summary>
        /// 树节点的数据
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


        private ObservableCollection<FuntionsModel> _listFuntions = new ObservableCollection<FuntionsModel>();

        /// <summary>
        /// 最新功能 有赞神厨
        /// </summary>
        public ObservableCollection<FuntionsModel> ListFuntions
        {
            get { return _listFuntions; }
            set
            {
                _listFuntions = value;
                RaisePropertyChanged();
            }
        }

    }


}
