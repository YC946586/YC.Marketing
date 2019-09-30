using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace YC.Model.Workbench
{
   public  class TodoModel: ViewModelBase
    {
        private string _items;
        private int _todeCount;
        private string _todedepict;
        /// <summary>
        /// 事项
        /// </summary>
        public string Items
        {
            get { return _items; }
            set
            {
                _items = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// 待办数量
        /// </summary>
        public int TodeCount
        {
            get { return _todeCount; }
            set
            {
                _todeCount = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// 待办
        /// </summary>
        public string Todedepict
        {
            get { return _todedepict; }
            set
            {
                _todedepict = value;
                RaisePropertyChanged();
            }
        }
    }
}
