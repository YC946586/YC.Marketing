using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YC.Client.Entity;
using YC.Client.Execute.Commons;
using YC.Client.Execute.UnityInjection.ViewDialog.CoreLib;
using YC.Model.Adhibition;

namespace YC.ViewModel.Adhibition
{
    public class AdhibitionViewModel : BaseOperation<AdhibitionModel>
    {
        public override void InitViewModel()
        {
            base.InitViewModel();
            try
            {
                //取出营销应用的功能节点
                var applyModel = Common.GetGnglEntityByFjd("0124c130f5e64e4b9c04eda4e31b0004");
                if (applyModel.Any())
                {
                    applyModel.ForEach((ary) =>
                    {
                        AdhibitionModel model = new AdhibitionModel
                        {
                            Title = ary.JDMC,
                            TitleDepict = ary.JDSX
                        };
                        var toolEntity = Common.GetGnglEntityByFjd(ary.ZJ);
                        if (toolEntity.Any())
                        {
                            toolEntity.ForEach((aty) =>
                            {
                                AdhibitionToolModel toolModel = new AdhibitionToolModel
                                {
                                    FunName = aty.JDMC,
                                    Depict = aty.JDSX,
                                    BrushsPath = aty.GNLX
                                };
                                model.ToolModesList.Add(toolModel);
                            });
                          
                        }
                        GridModelList.Add(model);
                    });
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
    }
}
