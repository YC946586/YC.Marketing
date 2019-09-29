using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MaterialDesignThemes.Wpf;

namespace YC.Client.Execute.UnityInjection.ViewDialog.CoreLib
{
    /// <summary>
    /// 主窗口基类  由痕迹大佬提供
    /// </summary>
    public partial class BaseOperation<T> : ViewModelBase where T : class, new()
    {

        #region 基类属性  [搜索、功能按钮、数据表单]

        private string searchText = string.Empty;
        private bool _DisplayGrid, _DisplayMetro = true;
        private ObservableCollection<T> _GridModelList;

        /// <summary>
        /// 搜索内容
        /// </summary>
        public string SearchText
        {
            get { return searchText; }
            set { searchText = value; RaisePropertyChanged(); }
        }

        public bool DisplayGrid
        {
            get { return _DisplayGrid; }
            set { _DisplayGrid = value; RaisePropertyChanged(); }
        }

        public bool DisplayMetro
        {
            get { return _DisplayMetro; }
            set { _DisplayMetro = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 表单数据
        /// </summary>
        public ObservableCollection<T> GridModelList
        {
            get { return _GridModelList; }
            set { _GridModelList = value; RaisePropertyChanged(); }
        }


        #endregion

        #region 基类实现

        /// <summary>
        /// 初始化
        /// </summary>
        public virtual void InitViewModel()
        {
            GridModelList = new ObservableCollection<T>();   
            this.Query(); //获取首次加载数据
        }


     
        #endregion

        #region 功能命令

        private RelayCommand<T> _AddCommand;
        private RelayCommand<T> _EditCommand;
        private RelayCommand<T> _DelCommand;
        private RelayCommand _QueryCommand;
        private RelayCommand _ResetCommand;
      

        /// <summary>
        /// 新增
        /// </summary>
        public RelayCommand<T> AddCommand
        {
            get
            {
                if (_AddCommand == null)
                {
                    _AddCommand = new RelayCommand<T>(t => Add(t));
                }
                return _AddCommand;
            }
            set { _AddCommand = value; }
        }

        /// <summary>
        /// 编辑
        /// </summary>
        public RelayCommand<T> EditCommand
        {
            get
            {
                if (_EditCommand == null)
                {
                    _EditCommand = new RelayCommand<T>(t => Edit(t));
                }
                return _EditCommand;
            }
            set { _EditCommand = value; }
        }

        /// <summary>
        /// 删除
        /// </summary>
        public RelayCommand<T> DelCommand
        {
            get
            {
                if (_DelCommand == null)
                {
                    _DelCommand = new RelayCommand<T>(t => Del(t));
                }
                return _DelCommand;
            }
            set { _DelCommand = value; }
        }

        /// <summary>
        /// 查询
        /// </summary>
        public RelayCommand QueryCommand
        {
            get
            {
                if (_QueryCommand == null)
                {
                    _QueryCommand = new RelayCommand(() => Query());
                }
                return _QueryCommand;
            }
            set { _QueryCommand = value; }
        }

        /// <summary>
        /// 重置
        /// </summary>
        public RelayCommand ResetCommand
        {
            get
            {
                if (_ResetCommand == null)
                {
                    _ResetCommand = new RelayCommand(() => Reset());
                }
                return _ResetCommand;
            }
            set { _ResetCommand = value; }
        }

        #region IDataOperation

        /// <summary>
        /// 新增
        /// </summary>
        public virtual void Add<TModel>(TModel model) { }

        /// <summary>
        /// 编辑
        /// </summary>
        public virtual void Edit<TModel>(TModel model) { }

        /// <summary>
        /// 删除
        /// </summary>
        public virtual void Del<TModel>(TModel model) { }


        /// <summary>
        /// 查询
        /// </summary>
        public virtual void Query() { }

        /// <summary>
        /// 重置
        /// </summary>
        public virtual void Reset()
        {
            this.SearchText = string.Empty;
        }

        #endregion

        #endregion
    }


    /// <summary>
    /// 弹出式窗口基类-Host
    /// </summary>
    public class BaseHostDialogOperation : ViewModelBase
    {
        /// <summary>
        /// 窗口标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 窗口打开时处理的逻辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        public virtual void ExtendedOpenedEventHandler(object sender, DialogOpenedEventArgs eventArgs)
        {

        }

        /// <summary>
        /// 窗口关闭前处理的逻辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        public virtual void ExtendedClosingEventHandler(object sender, DialogClosingEventArgs eventArgs)
        {
            if ((bool)eventArgs.Parameter == false) return;
        }
    }

    /// <summary>
    /// 弹出式窗口基类-Window
    /// </summary>
    public class BaseDialogOperation : ViewModelBase
    {
        public bool Result { get; set; }

        private RelayCommand _CancelCommand;
        private RelayCommand _SaveCommand;

        public RelayCommand CancelCommand
        {
            get
            {
                if (_CancelCommand == null)
                    _CancelCommand = new RelayCommand(() => Cancel());
                return _CancelCommand;
            }
        }

        public RelayCommand SaveCommand
        {
            get
            {
                if (_SaveCommand == null)
                    _SaveCommand = new RelayCommand(() => Save());
                return _SaveCommand;
            }
        }

        /// <summary>
        /// 取消
        /// </summary>
        public void Cancel()
        {
            Result = false;
            Messenger.Default.Send("", "Close");
        }

        /// <summary>
        /// 确定
        /// </summary>
        public void Save()
        {
            Result = true;
            Messenger.Default.Send("", "Close");
        }
    }
}
