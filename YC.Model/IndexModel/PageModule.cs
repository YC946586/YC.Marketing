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

        public PageModule(  string funName, string funIcon, string openSpace, int isOpt, int? authorities=0)
        {         
            FunIcon = funIcon;
            FunName = funName;
            OpenSpace = openSpace;
            Authorities = authorities;
            IsOpt = isOpt;
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
        public string OpenSpace { get; }

        /// <summary>
        /// 权限值
        /// </summary>
        public int? Authorities { get; }

        /// <summary>
        /// 当前功能
        /// </summary>
        public PageModule Curmodel { get; }


        private int _isOpt;
        /// <summary>
        /// 是否选中
        /// </summary>
        public int IsOpt
        {
            get { return _isOpt; }
            set { _isOpt = value; RaisePropertyChanged(); }
        }

    }
}
