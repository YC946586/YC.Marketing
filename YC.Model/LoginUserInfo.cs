using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace YC.Model
{
   public  class LoginUserInfo: ViewModelBase
    {
        private string _userId = string.Empty;
        private string _userIcon = string.Empty;
        private string _userName = string.Empty;
        private bool _admin = false;
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserId
        {
            get { return _userId; }
            set { _userId = value;
                RaisePropertyChanged(); }
        }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string UserIcon
        {
            get { return _userIcon; }
            set
            {
                _userIcon = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get
            {
                return _userName;
            }
            set { _userName = value;
                RaisePropertyChanged(); }
        }

        /// <summary>
        /// 是否属于管理员
        /// </summary>
        public bool IsAdmin
        {
            get { return _admin; }
            set
            {
                _admin = value;
                RaisePropertyChanged();
            }
        }
    }
}
