using System.Data;

namespace YC.Client.Data
{
    /// <summary>
    /// 接口层 为什么不用抽象类 因为我用动软生成数据访问层 懒得去改。
    /// 等业务需要了 再改
    /// </summary>
    public interface IUsDataDal<T> where T : class, new()
    {
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists(string zj);
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
        bool Delete(string zj);
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        T GetModel(string zj);
        ///// <summary>
        ///// 附加方法 用于本身生成代码业务不支持
        ///// </summary>
        //T Addition(T model);
        /// <summary>
        /// 获得数据列表
        /// </summary>
        DataSet GetList(string strWhere);
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        DataSet GetList(int top, string strWhere, string filedOrder);

    }
}