using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace YC.Model.IndexModel
{
   public  class PageModule: ViewModelBase
    {

        public PageModule(  string funName,  string openSpace, int isCheck, int? authorities=0)
        {         
            FunName = funName;
            //FunIcon = funIcon;
            OpenSpace = openSpace;
            Authorities = authorities;
            IsCheck = isCheck;
        }

        /// <summary>
        /// 图标-IconFont
        /// </summary>
        public string FunIcon { get; }

        /// <summary>
        /// 功能名称
        /// </summary>
        public string FunName { get; }
        /// <summary>
        /// 功能打开路径
        /// </summary>
        public string OpenSpace { get; set; }

        /// <summary>
        /// 权限值
        /// </summary>
        private int? Authorities { get; }

        /// <summary>
        /// 当前功能
        /// </summary>
        public PageModule Curmodel { get; }


        private int _isCheck;
        /// <summary>
        /// 是否选中
        /// </summary>
        public int IsCheck
        {
            get { return _isCheck; }
            set { _isCheck = value; RaisePropertyChanged(); }
        }

    }
}
