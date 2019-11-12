using System.Data;

namespace YC.Client.Data
{
    /// <summary>
    /// 接口层
    /// </summary>
    public interface IUsDataDal<T> where T : class, new()
    {
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists(string ZJ);
        /// <summary>
        /// 增加一条数据
        /// </summary>
        void Add(T model);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(T model);
        /// <summary>
        /// 删除数据
        /// </summary>
        bool Delete(string ZJ);
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        T GetModel(string ZJ);
        /// <summary>
        /// 获得数据列表
        /// </summary>
        DataSet GetList(string strWhere);
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        DataSet GetList(int Top, string strWhere, string filedOrder);

    }
}