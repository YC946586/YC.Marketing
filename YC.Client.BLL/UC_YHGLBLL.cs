using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using YC.Client.DAL;
using YC.Client.Entity;

namespace YC.Client.BLL
{
	 	//UC_YHGL
		public partial class UC_YHGLBLL
	{
	
	    private static UC_YHGLDAL dal = new UC_YHGLDAL();
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public UC_YHGLEntity QueryUC_YHGLByGUID(string guid)
		{
			return dal.QueryUC_YHGLByGUID(guid);
		}
		
		/// <summary>
		/// 通过筛选条件查询功能管理
		/// </summary>
		public List<UC_YHGLEntity> ScreenUC_YHGL(UC_YHGLEntity model)
		{
			return dal.ScreenUC_YHGL( model);
		}
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int InsertUC_YHGL(UC_YHGLEntity model)
		{
			return dal.InsertUC_YHGL( model);
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int UpdateUC_YHGL(UC_YHGLEntity model)
		{
			return dal.UpdateUC_YHGL( model);
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int DeleteUC_YHGL(string guid)
		{
			return dal.DeleteUC_YHGL(guid);
		}
	}
}