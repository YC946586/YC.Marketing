using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YC.Client.Entity.Zcgl;

namespace YC.Model.Asset
{
    /// <summary>
    /// dategrid 展示数据模型
    /// </summary>
   public  class AssetModel: ViewModelBase
    {
        private DateTime _stTime;
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime StTime
        {
            get { return _stTime; }
            set
            {
                _stTime = value;
                RaisePropertyChanged();
            }
        }

        private string _type;
        /// <summary>
        /// 类型
        /// </summary>
        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                RaisePropertyChanged();
            }
        }
        private string _name;
        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }

        private decimal _money;
        /// <summary>
        /// 金额
        /// </summary>
        public decimal Money
        {
            get { return _money; }
            set
            {
                _money = value;
                RaisePropertyChanged();
            }
        }

        private string _accountNmae;
        /// <summary>
        /// 账户名称
        /// </summary>
        public string AccountNmae
        {
            get { return _accountNmae; }
            set
            {
                _accountNmae = value;
                RaisePropertyChanged();
            }
        }
        private decimal _Accountmoney;
        /// <summary>
        /// 账户余额
        /// </summary>
        public decimal AccountMoney
        {
            get { return _Accountmoney; }
            set
            {
                _Accountmoney = value;
                RaisePropertyChanged();
            }
        }
        private string _userName;
        /// <summary>
        /// 会员
        /// </summary>
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                RaisePropertyChanged();
            }
        }

        private long? _phone;
        /// <summary>
        /// 会员
        /// </summary>
        public long? Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                RaisePropertyChanged();
            }
        }
        
    }


    public class  PayModel: ViewModelBase
    {
        private string _type;
        /// <summary>
        /// 类型
        /// </summary>
        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                RaisePropertyChanged();
            }
        }

        private decimal _money;
        /// <summary>
        /// 金额
        /// </summary>
        public decimal Money
        {
            get { return _money; }
            set
            {
                _money = value;
                RaisePropertyChanged();
            }
        }

    }
}
