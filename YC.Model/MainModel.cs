using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace YC.Model
{
    public class MainModel: ViewModelBase
    {
        private string headerName;
        /// <summary>
        /// 标题
        /// </summary>
        public string HeaderName
        {
            get { return headerName; }
            set { headerName = value; }
        }


        private LoginUserInfo _userInfo = new LoginUserInfo();
        /// <summary>
        /// 用户信息
        /// </summary>
        public LoginUserInfo UserInfo
        {
            get { return _userInfo; }
            set
            {
                _userInfo = value;
                RaisePropertyChanged();
            }
        }
    }
}
