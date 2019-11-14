using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace YC.Model.Workbench
{
   public  class KhDataModel : ViewModelBase
    {
        private string _title;
        private string _todeCount;
        private string _yestAmount;
        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// 数量
        /// </summary>
        public string TodeCount
        {
            get { return _todeCount; }
            set
            {
                _todeCount = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// 昨日数量
        /// </summary>
        public string YestAmount
        {
            get { return _yestAmount; }
            set
            {
                _yestAmount = value;
                RaisePropertyChanged();
            }
        }
    }
}
