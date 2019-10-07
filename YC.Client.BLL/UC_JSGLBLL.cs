using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using YC.Client.Entity;
using YC.Client.DAL;
namespace YC.Client.BLL
{
	 	//UC_JSGL
		public partial class UC_JSGLBLL
	{
	
	    private static UC_JSGLDAL dal = new UC_JSGLDAL();
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public UC_JSGLEntity QueryUC_JSGLByGUID(string guid)
		{
			return dal.QueryUC_JSGLByGUID(guid);
		}
		
		/// <summary>
		/// 通过筛选条件查询功能管理
		/// </summary>
		public List<UC_JSGLEntity> ScreenUC_JSGL(UC_JSGLEntity model)
		{
			return dal.ScreenUC_JSGL( model);
		}
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int InsertUC_JSGL(UC_JSGLEntity model)
		{
			return dal.InsertUC_JSGL( model);
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int UpdateUC_JSGL(UC_JSGLEntity model)
		{
			return dal.UpdateUC_JSGL( model);
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int DeleteUC_JSGL(string guid)
		{
			return dal.DeleteUC_JSGL(guid);
		}
	}
}