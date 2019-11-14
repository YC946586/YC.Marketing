using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YC.Client.Entity;
using YC.Client.Entity.Gngl;
using YC.Client.Execute.Commons;
using YC.Client.Execute.UnityInjection.ViewDialog.CoreLib;
using YC.Model.IndexModel;
using YC.Model.Workbench;
using YC.RequestConver;

namespace YC.ViewModel.Workbench
{
    public class WorkbenchViewModel : BaseOperation<WorkbenchModel>
    {

        /// <summary>
        /// 待办事项
        /// </summary>
        private readonly Dictionary<string, string> _dicTodo = new Dictionary<string, string>
        {
            {"待服务", "预约单"},
            {"待付款", "服务订单"},
            {"待发货", "产品订单"},
            {"待审核", "推广员申请"}
        };

        /// <summary>
        /// 初始化工作台
        /// </summary>
        public override void InitViewModel()
        {
            try
            {
                base.InitViewModel();
                WorkbenchModel model = new WorkbenchModel()
                {
                    A = "sadasd",
                    B = "sdasd2w222asdas"
                };
                //工作台数据
                var gztModel = Common.GetGnglEntityByFjd("0124c130f5e64e4b9c04eda4e31b0002");

                //常用功能
                var cygnModel = Common.GetGnglEntityByFjd(gztModel.Find(s=>s.JDPX==2).ZJ);
                if (cygnModel.Any())
                {
                    cygnModel.ForEach((ary) =>
                    {
                        PageModule pageModel = new PageModule(ary.JDMC, ary.JDSX, ary.JDPX);
                        model.ListFun.Add(pageModel);
                    });
                }

                #region 最新宣传 最新功能 有赞神厨   

                var broadcastModel = gztModel.Where(s => s.JDPX == 4).ToList();
                if (broadcastModel.Any())
                {
                    broadcastModel.ForEach((ary) =>
                    {
                        FuntionsModel broadc = new FuntionsModel()
                        {
                            FunName = ary.JDMC,
                        };
                        var dapiModel = Common.GetGnglEntityByFjd(ary.ZJ);

                        dapiModel.ForEach((aty) =>
                        {
                            depictModel dapi = new depictModel()
                            {
                                Depict = aty.JDSX,
                            };
                            broadc.ListFuntions.Add(dapi);
                        });
                        model.Listbroadcast.Add(broadc);
                    });
                }
                #endregion

                //待办事项
                foreach (KeyValuePair<string, string> t in _dicTodo)
                {
                    TodoModel model1 = new TodoModel()
                    {
                        Items = t.Key,
                        TodeCount = new Random().Next(10, 200),
                        Todedepict = t.Value
                    };
                    model.ListTodo.Add(model1);
                }

                GridModelList.Add(model);
            }
            catch (Exception ex)
            {
                
                throw;
            }
         
        }
    }
}
