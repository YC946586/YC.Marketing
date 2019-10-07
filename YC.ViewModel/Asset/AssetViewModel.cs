using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YC.Client.Execute.UnityInjection.ViewDialog.CoreLib;
using YC.Model.Asset;
using YC.Model.Workbench;

namespace YC.ViewModel.Asset
{
    public class AssetViewModel : BaseOperation<AssetModel>
    {


        private ObservableCollection<PayModel> _PayModelList;

        /// <summary>
        /// 表单数据
        /// </summary>
        public ObservableCollection<PayModel> PayModelList
        {
            get { return _PayModelList; }
            set { _PayModelList = value; RaisePropertyChanged(); }
        }
        private string _store;
        /// <summary>
        /// 储存金额
        /// </summary>
        public string Store
        {
            get { return _store; }
            set
            {
                _store = value;
                RaisePropertyChanged();
            }
        }
        /// <summary>
        /// 初始化
        /// </summary>
        public override void InitViewModel()
        {
            base.InitViewModel();
            Store = "999.00";
            PayModelList = new ObservableCollection<PayModel>();

            for (int i = 0; i < 4; i++)
            {
                PayModel model = new PayModel()
                {
                    Type = "今日充值",
                    Money = 500 * i + 200
                };
                PayModelList.Add(model);
            }
            AssetModel date = new AssetModel()
            {
                StTime = DateTime.Now,
                Type="充值",
                Name="充值赠送了1000元",
                Money=2982,
                AccountNmae="系统账户",
                AccountMoney=5322,
                UserName="洋葱",
                Phone=13666142357
            };
            GridModelList.Add(date);
        }

        /// <summary>
        /// 提现
        /// </summary>
        public override void Reset()
        {
            base.Reset();
        }
    }
}
