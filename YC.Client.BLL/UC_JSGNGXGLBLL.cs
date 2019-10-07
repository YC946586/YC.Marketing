using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using YC.Client.Entity;
using YC.Client.DAL;
namespace YC.Client.BLL
{
	 	//UC_JSGNGXGL
		public partial class UC_JSGNGXGLBLL
	{
	
	    private static UC_JSGNGXGLDAL dal = new UC_JSGNGXGLDAL();
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public UC_JSGNGXGLEntity QueryUC_JSGNGXGLByGUID(string guid)
		{
			return dal.QueryUC_JSGNGXGLByGUID(guid);
		}
		
		/// <summary>
		/// 通过筛选条件查询功能管理
		/// </summary>
		public List<UC_JSGNGXGLEntity> ScreenUC_JSGNGXGL(UC_JSGNGXGLEntity model)
		{
			return dal.ScreenUC_JSGNGXGL( model);
		}
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int InsertUC_JSGNGXGL(UC_JSGNGXGLEntity model)
		{
			return dal.InsertUC_JSGNGXGL( model);
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int UpdateUC_JSGNGXGL(UC_JSGNGXGLEntity model)
		{
			return dal.UpdateUC_JSGNGXGL( model);
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int DeleteUC_JSGNGXGL(string guid)
		{
			return dal.DeleteUC_JSGNGXGL(guid);
		}
	}
}