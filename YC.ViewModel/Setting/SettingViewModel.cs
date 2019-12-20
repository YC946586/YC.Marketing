using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using YC.Client.Entity.Zcgl;
using YC.Client.Execute.Commons;
using YC.Client.Execute.UnityInjection.ViewDialog.CoreLib;
using YC.Model.Setting;

namespace YC.ViewModel.Setting
{
    public class SettingViewModel : BaseOperation<SettingModel>
    {
        private ObservableCollection<SettingModel> _ContentList = new ObservableCollection<SettingModel>();

        /// <summary>
        /// 表单数据
        /// </summary>
        public ObservableCollection<SettingModel> ContentList
        {
            get { return _ContentList; }
            set
            {
                _ContentList = value;
                RaisePropertyChanged();
            }
        }



        public override void InitViewModel()
        {
            try
            {
                base.InitViewModel();

                var systemModel = Common.GetGnglEntityByFjd("0124c130f5e64e4b9c04eda4e31b0008");
                systemModel.ForEach((ary) =>
                {
                    SettingModel model = new SettingModel();
                    model.HeaderName = ary.JDMC;
                    model.Body = Common.GetUserControl(ary.JDSX);
                    GridModelList.Add(model);
                    ContentList.Add(model);
                });         
            }
            catch (Exception ex)
            {
                
                throw;
            }
          

            
        }
    }
}
