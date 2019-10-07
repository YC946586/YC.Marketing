using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using YC.Client.Entity;
using YC.Client.DAL;
namespace YC.Client.BLL
{
	 	//UC_GNGL
		public partial class UC_GNGLBLL
	{
	
	    private static UC_GNGLDAL dal = new UC_GNGLDAL();
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public UC_GNGLEntity QueryUC_GNGLByGUID(string guid)
		{
			return dal.QueryUC_GNGLByGUID(guid);
		}
		
		/// <summary>
		/// 通过筛选条件查询功能管理
		/// </summary>
		public List<UC_GNGLEntity> ScreenUC_GNGL(UC_GNGLEntity model)
		{
			return dal.ScreenUC_GNGL( model);
		}
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int InsertUC_GNGL(UC_GNGLEntity model)
		{
			return dal.InsertUC_GNGL( model);
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int UpdateUC_GNGL(UC_GNGLEntity model)
		{
			return dal.UpdateUC_GNGL( model);
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int DeleteUC_GNGL(string guid)
		{
			return dal.DeleteUC_GNGL(guid);
		}
	}
}