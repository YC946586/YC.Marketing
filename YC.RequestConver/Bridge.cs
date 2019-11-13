using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using YC.Client.Data;

namespace YC.RequestConver
{
    public class Bridge<T> where T : class, new()
    {
        /// <summary>
        /// 获取对应的数据访问层
        /// </summary>
        private readonly IUsDataDal<T> _dal = DataAccess.CreateusData<T>();

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string zj)
        {
            return _dal.Exists(zj);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(T model)
        {
            _dal.Add(model);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(T model)
        {
            return _dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string zj)
        {
            return _dal.Delete(zj);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public T GetModel(string zj)
        {
            return _dal.GetModel(zj);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public List<T> GetList(int top, string strWhere, string filedOrder)
        {
            DataSet ds = _dal.GetList(top, strWhere, filedOrder);
            return DataTableToList(ds);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<T> GetModelList(string strWhere)
        {
            DataSet ds = _dal.GetList(strWhere);
            return DataTableToList(ds);
        }

        /// <summary>
        /// 附加方法 实现自己对应的逻辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<T> Addition(T model)
        {
            DataSet ds = _dal.Addition(model);
            return DataTableToList(ds);
        }
        #region Private methods

        /// <summary>
        /// 获得数据列表
        /// </summary>
        private List<T> DataTableToList(DataSet dt)
        {
            var data = DataSetToEntityList<T>(dt);
            List<T> modelList = data.ToList();
            return modelList;
        }


        /// <summary>
        /// DataSet转换为实体列表
        /// </summary>
        /// <typeparam name="T">实体类</typeparam>
        /// <param name="pDataSet">DataSet</param>
        /// <param name="pTableIndex">待转换数据表索引</param>
        /// <returns>实体类列表</returns>
        private static IList<T> DataSetToEntityList<T>(DataSet pDataSet, int pTableIndex = 0)
        {
            try
            {
                if (pDataSet == null || pDataSet.Tables.Count < 0)
                    return default(IList<T>);
                if (pTableIndex > pDataSet.Tables.Count - 1)
                    return default(IList<T>);
                if (pTableIndex < 0)
                    pTableIndex = 0;
                if (pDataSet.Tables[pTableIndex].Rows.Count <= 0)
                    return default(IList<T>);

                DataTable p_Data = pDataSet.Tables[pTableIndex];
                // 返回值初始化
                IList<T> result = new List<T>();
                for (int j = 0; j < p_Data.Rows.Count; j++)
                {
                    T _t = (T)Activator.CreateInstance(typeof(T));
                    PropertyInfo[] propertys = _t.GetType().GetProperties();
                    foreach (PropertyInfo pi in propertys)
                    {
                        if (p_Data.Columns.IndexOf(pi.Name.ToUpper()) != -1 && p_Data.Rows[j][pi.Name.ToUpper()] != DBNull.Value)
                        {
                            object value = p_Data.Rows[j][pi.Name.ToUpper()];
                            if (pi.PropertyType.FullName == "System.Int32")//此处判断下Int32类型，如果是则强转
                                value = Convert.ToInt32(value);
                            pi.SetValue(_t, value, null);
                        }
                        else
                        {
                            pi.SetValue(_t, null, null);
                        }
                    }
                    result.Add(_t);
                }
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }

        }


        #endregion


        #endregion

    }
}