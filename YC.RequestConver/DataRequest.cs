using System;
using System.Collections.Generic;
using System.Data;
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
        public static bool Exists(dynamic zj)
        {
            try
            {
                Bridge<T> bll = new Bridge<T>();
                return bll.Exists(zj);
            }
            catch (Exception ex)
            {
                return false;
            }
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
        public static bool Delete(string zj)
        {
            Bridge<T> bll = new Bridge<T>();
            return bll.Delete(zj);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public static T GetModel(string zj)
        {
            Bridge<T> bll = new Bridge<T>();
            return bll.GetModel(zj);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static List<T> GetModelList(string strWhere)
        {
            try
            {
                Bridge<T> bll = new Bridge<T>();
                return bll.GetModelList(strWhere);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public static List<T> GetList(int Top, string strWhere, string filedOrder)
        {
            try
            {
                Bridge<T> bll = new Bridge<T>();
                return bll.GetList(Top, strWhere, filedOrder);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// 附加方法 实现自己对应的逻辑
        /// </summary>
        public static List<T> Addition(T entity)
        {
            try
            {
                Bridge<T> bll = new Bridge<T>();
                return bll.Addition(entity);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
    }


}
