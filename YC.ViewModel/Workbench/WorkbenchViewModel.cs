using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YC.Client.Entity;
using YC.Client.Execute.UnityInjection.ViewDialog.CoreLib;
using YC.Model.IndexModel;
using YC.Model.Workbench;

namespace YC.ViewModel.Workbench
{
    public class WorkbenchViewModel: BaseOperation<WorkbenchModel>
    {
        public override void InitViewModel()
        {
            base.InitViewModel();
            WorkbenchModel model = new WorkbenchModel()
            {
                A = "sadasd",
                B = "sdasd2w222asdas"
            };

            for (int i = 0; i < 8; i++)
            {
                //var rd=new Random().Next(1,8);           
                PageModule pageModel = new PageModule("快捷开单", "快捷开单", "YC.ClientView.Workbench.WorkbenchViewDog", i+1);
                model.ListFun.Add(pageModel);
            }
            for (int i = 0; i < 4; i++)
            {
                TodoModel model1=new TodoModel()
                {
                    Items="待服务",
                    TodeCount = 10,
                    Todedepict = "预约单"
                };
                model.ListTodo.Add(model1);
            }
            for (int i = 0; i < 2; i++)
            {
                FuntionsModel fun=new FuntionsModel()
                {
                    FunName = "最新功能"+i,          
                };
                for (int j = 0; j < 5; j++)
                {
                    depictModel dapi = new depictModel()
                    {
                        Depict=DateTime.Now.ToString("yyyy-M-d dddd")+j+"功能上新了",
                    };

                    fun.ListFuntions.Add(dapi);
                }
                model.ListFuntions.Add(fun);
            }

            //最新功能 有赞神厨
           RequestConver.GnglBridge.GetModel(new us_gnglModel());
            //ListFuntions
           GridModelList.Add(model);
        }
    }
}
