using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            for (int i = 0; i < 3; i++)
            {
                TodoModel model1=new TodoModel()
                {
                    Items="待服务",
                    TodeCount = 10,
                    Todedepict = "预约单"
                };
                model.ListTodo.Add(model1);
            }
          


            GridModelList.Add(model);
        }
    }
}
