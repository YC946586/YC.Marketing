using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YC.Client.BLL;
using YC.Client.Entity;

namespace YC.RequestConver
{
    public static class Class1
    {
          public static void getYHgl()
        {
            UC_YHGLBLL yHGLBLL = new UC_YHGLBLL();
            var cc = yHGLBLL.ScreenUC_YHGL(new UC_YHGLEntity() { });
        }
    }
}
