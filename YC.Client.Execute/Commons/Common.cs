using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using YC.Client.Entity;
using YC.Client.Entity.Gngl;

namespace YC.Client.Execute.Commons
{
    public static class Common
    {
        /// <summary>
        /// 根据传入ID获取当前功能
        /// </summary>
        /// <param name="funID"></param>
        /// <returns></returns>
        public static UcGnglEntity GetGnglEntityById(string funID)
        {
            var liveFun = LoginResultData.TheMainConfig.First(s => s.ZJ.Equals(funID));
            return liveFun;
        }

        /// <summary>
        /// 根据传入父节点取子节点
        /// </summary>
        /// <param name="funFid"></param>
        /// <returns></returns>
        public static List<UcGnglEntity> GetGnglEntityByFjd(string funFid)
        {
            var liveFun =
                LoginResultData.TheMainConfig.Where(s => !string.IsNullOrEmpty(s.F_FJDZJ) && s.F_FJDZJ.Equals(funFid)).ToList();  
            return liveFun;
        }

        /// <summary>
        /// 反射UserControl
        /// </summary>
        /// <returns></returns>
        public static UserControl GetUserControl(string userctolAction)
        {
            try
            {
                UserControl uc = null;
                //控件所在DLL
                var actionFile = "YC.ClientView.dll";

                uc =
                       (UserControl)
                       Assembly.LoadFile(AppDomain.CurrentDomain.BaseDirectory + actionFile).CreateInstance(userctolAction);

                return uc;
            }
            catch (Exception ex)
            {
                return null;
                throw;
            }
        }
    }
}
