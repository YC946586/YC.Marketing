using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YC.Client.Execute.Commons
{
    public static class RefreshCommon
    {
        //静态属性通知事件 (4.5支持)
        public static event EventHandler<PropertyChangedEventArgs> StaticPropertyChanged;
        private static string _indexNmae = string.Empty;

        private static object _selectMenuGroup;
        /// <summary>
        /// 首页的名称
        /// </summary>
        public static string IndexName
        {
            get { return _indexNmae; }
            set
            {
                _indexNmae = value;
                if (StaticPropertyChanged != null)
                {
                    StaticPropertyChanged.Invoke(null, new PropertyChangedEventArgs("IndexName"));
                }
            }
        }


        /// <summary>
        /// 选中的 功能节点
        /// </summary>
        public static object SelectMenuGroup
        {
            get { return _selectMenuGroup; }
            set
            {
                _selectMenuGroup = value;
                if (StaticPropertyChanged != null)
                {
                    StaticPropertyChanged.Invoke(null, new PropertyChangedEventArgs("SelectMenuGroup"));
                }
            }
        }
    }
}
