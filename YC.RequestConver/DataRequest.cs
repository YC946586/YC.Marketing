using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YC.Client.Entity;

namespace YC.RequestConver
{
    /// <summary>
    /// 数据请求
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class DataRequest<T> where T : class, new()
    {
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public static bool Exists(dynamic ZJ)
        {
            Bridge<T> bll = new Bridge<T>();
            return bll.Exists(ZJ);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public static void Add(T model)
        {
            Bridge<T> bll = new Bridge<T>();
            bll.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool Update(T model)
        {
            Bridge<T> bll = new Bridge<T>();
            return bll.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public static bool Delete(string ZJ)
        {
            Bridge<T> bll = new Bridge<T>();
            return bll.Delete(ZJ);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public static T GetModel(string ZJ)
        {
            Bridge<T> bll = new Bridge<T>();
            return bll.GetModel(ZJ);
        }


    }

  
}
