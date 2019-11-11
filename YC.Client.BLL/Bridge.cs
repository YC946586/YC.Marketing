using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YC.Client.Data;
using YC.Client.DAL;
using YC.Client.Entity;

namespace YC.Client.BLL
{
    public partial class Bridge<T> where T : class, new()
    {
        /// <summary>
        /// 获取对应的数据访问层
        /// </summary>
        private readonly IUsDataDal<T> _dal = DataAccess.CreateusData<T>();

        public Bridge()
        {
        }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ZJ)
        {
            return _dal.Exists(ZJ);
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
        public bool Delete(string ZJ)
        {

            return _dal.Delete(ZJ);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public T GetModel(string ZJ)
        {

            return _dal.GetModel(ZJ);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public T GetModelByCache(string ZJ)
        {

            //string CacheKey = "us_gnglModel-" + ZJ;
            //object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            //if (objModel == null)
            //{
            //    try
            //    {
            //        objModel = dal.GetModel(ZJ);
            //        if (objModel != null)
            //        {
            //            int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
            //            Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
            //        }
            //    }
            //    catch { }
            //}

            //return (us_gnglModel)objModel;
            return new T();
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return _dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return _dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<T> GetModelList(string strWhere)
        {
            DataSet ds = _dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<T> DataTableToList(DataTable dt)
        {
            List<T> modelList = new List<T>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                //us_gnglModel model;
                //for (int n = 0; n < rowsCount; n++)
                //{
                //    model = new us_gnglModel();
                //    model.ZJ = dt.Rows[n]["ZJ"].ToString();
                //    model.JDMC = dt.Rows[n]["JDMC"].ToString();
                //    model.F_FJDZJ = dt.Rows[n]["F_FJDZJ"].ToString();
                //    if (dt.Rows[n]["DJ"].ToString() != "")
                //    {
                //        model.DJ = decimal.Parse(dt.Rows[n]["DJ"].ToString());
                //    }
                //    if (dt.Rows[n]["JDPX"].ToString() != "")
                //    {
                //        model.JDPX = decimal.Parse(dt.Rows[n]["JDPX"].ToString());
                //    }
                //    if (dt.Rows[n]["GNBZ"].ToString() != "")
                //    {
                //        model.GNBZ = decimal.Parse(dt.Rows[n]["GNBZ"].ToString());
                //    }
                //    model.JDLX = dt.Rows[n]["JDLX"].ToString();
                //    model.JDSX = dt.Rows[n]["JDSX"].ToString();
                //    model.REMARK = dt.Rows[n]["REMARK"].ToString();
                //    if (dt.Rows[n]["QYBZ"].ToString() != "")
                //    {
                //        model.QYBZ = decimal.Parse(dt.Rows[n]["QYBZ"].ToString());
                //    }
                //    model.GXR = dt.Rows[n]["GXR"].ToString();
                //    model.CJR = dt.Rows[n]["CJR"].ToString();
                //    if (dt.Rows[n]["GXSJ"].ToString() != "")
                //    {
                //        model.GXSJ = DateTime.Parse(dt.Rows[n]["GXSJ"].ToString());
                //    }
                //    if (dt.Rows[n]["CJSJ"].ToString() != "")
                //    {
                //        model.CJSJ = DateTime.Parse(dt.Rows[n]["CJSJ"].ToString());
                //    }
                //    if (dt.Rows[n]["VIPTYPE"].ToString() != "")
                //    {
                //        model.VIPTYPE = int.Parse(dt.Rows[n]["VIPTYPE"].ToString());
                //    }


                //    modelList.Add(model);
                //}
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }
        #endregion

    }
}