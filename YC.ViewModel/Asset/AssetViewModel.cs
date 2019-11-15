using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YC.Client.Entity.Zcgl;
using YC.Client.Execute.Commons;
using YC.Client.Execute.UnityInjection.ViewDialog.CoreLib;
using YC.Model.Asset;
using YC.Model.Workbench;

namespace YC.ViewModel.Asset
{
    /// <summary>
    /// 资产管理
    /// </summary>
    public class AssetViewModel : BaseOperation<UcZcglEntity>
    {
        private ObservableCollection<PayModel> _payModelList;

        /// <summary>
        /// 表单数据
        /// </summary>
        public ObservableCollection<PayModel> PayModelList
        {
            get { return _payModelList; }
            set { _payModelList = value; RaisePropertyChanged(); }
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
        public override async void InitViewModel()
        {
            base.InitViewModel();
            Store = "999.00";
            PayModelList = new ObservableCollection<PayModel>();

            List<string> listPayList = new List<string> {"今日充值", "今日耗卡", "今日赠送", "储值金额"};
         
            listPayList.ForEach((ary) =>
            {
                PayModel model = new PayModel()
                {
                    Type = ary,
                    Money = Convert.ToDecimal(Common.GetRandomSeed())
                };
                PayModelList.Add(model);
            });

            //Get Zcgllist
            var assstEntity =await RequestConver.DataRequest<UcZcglEntity>.GetModelList();

            if (assstEntity!=null&& assstEntity.Count!=0)
            {
                assstEntity.ForEach((ary)=> GridModelList.Add(ary));
            }
           
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
