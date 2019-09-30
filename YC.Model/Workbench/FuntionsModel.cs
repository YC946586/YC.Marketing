using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace YC.Model.Workbench
{
    public  class FuntionsModel: ViewModelBase
    {
        private string _funName;
        /// <summary>
        /// 节点主名称
        /// </summary>
        public string FunName
        {
            get { return _funName; }
            set
            {
                _funName = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<depictModel> _listFuntions = new ObservableCollection<depictModel>();

        /// <summary>
        /// 功能描述
        /// </summary>
        public ObservableCollection<depictModel> ListFuntions
        {
            get { return _listFuntions; }
            set
            {
                _listFuntions = value;
                RaisePropertyChanged();
            }
        }
    }

    public class depictModel : ViewModelBase
    {
        private string _depict;
        /// <summary>
        /// 节点主名称
        /// </summary>
        public string Depict
        {
            get { return _depict; }
            set
            {
                _depict = value;
                RaisePropertyChanged();
            }
        }

        private DateTime? _stsrtTime;
        /// <summary>
        /// 开始时间 暂时不用
        /// </summary>
        public DateTime? StsrtTime
        {
            get { return _stsrtTime; }
            set
            {
                _stsrtTime = value;
                RaisePropertyChanged();
            }
        }
    }
}
