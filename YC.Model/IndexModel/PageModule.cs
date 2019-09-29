using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YC.Model.IndexModel
{
   public  class PageModule
    {
        public PageModule(  string funName, string funIcon, string openSpace,int? authorities=0)
        {         
            FunIcon = funIcon;
            FunName = funName;
            OpenSpace = openSpace;
            Authorities = authorities;
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
    }
}
