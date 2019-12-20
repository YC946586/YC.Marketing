using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace YC.Model.Setting
{
    public class SettingModel: ViewModelBase
    {
        private string headerName;
        private object body;
        private string _back = "CCCCCC";

        /// <summary>
        /// 标题
        /// </summary>
        public string HeaderName
        {
            get { return headerName; }
            set { headerName = value; }
        }

        /// <summary>
        /// 窗口内容
        /// </summary>
        public object Body
        {
            get { return body; }
            set { body = value; }
        }

        /// <summary>
        /// 标题
        /// </summary>
        public string back
        {
            get { return _back; }
            set { _back = value; }
        }

    }
}
