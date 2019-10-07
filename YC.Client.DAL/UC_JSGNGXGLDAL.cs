using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using YC.Client.Entity;
using MySql.Data.MySqlClient;
namespace YC.Client.DAL
{
	 	//UC_JSGNGXGL
		public partial class UC_JSGNGXGLDAL
	{
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public UC_JSGNGXGLEntity QueryUC_JSGNGXGLByGUID(string guid)
		{
			try{
				StringBuilder strSql=new StringBuilder();
				strSql.Append("select ZJ, F_JSZJ, F_GNZJ, GXSJ, QYBZ  ");			
				strSql.Append("  from UC_JSGNGXGL ");
				strSql.Append(" where ZJ = @ZJ");
				 MySqlParameter[] parameters = {new MySqlParameter("@ZJ", MySqlDbType.VarChar,32)};           
				parameters[0].Value = guid;
				UC_JSGNGXGLEntity model=new UC_JSGNGXGLEntity();
				DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			   foreach (DataRow item in ds.Tables[0].Rows)
                {
                    DbHelperMySQL.DataRowToEntity<UC_JSGNGXGLEntity>(item, ref model);
				}				
			return model;
			}
            catch (Exception ex)
            {
               throw;
            }
		}
		
		/// <summary>
		/// 通过筛选条件查询功能管理
		/// </summary>
		public List<UC_JSGNGXGLEntity> ScreenUC_JSGNGXGL(UC_JSGNGXGLEntity model)
		{
		try{
		StringBuilder strSql=new StringBuilder();
			strSql.Append("select ZJ, F_JSZJ, F_GNZJ, GXSJ, QYBZ  ");			
			strSql.Append("  from UC_JSGNGXGL ");
			strSql.Append(" where 1=1 ");

				List<MySqlParameter> parameters = new List<MySqlParameter>();
																		
								
				if(!String.IsNullOrEmpty(model.ZJ))
				{
				strSql.Append(" and ZJ like @ZJ ");
				MySqlParameter sq = new MySqlParameter("@ZJ", MySqlDbType.String);           
				sq.Value =  "%"+model.ZJ+"%";
				parameters.Add(sq);
				}
																				
																
								
				if(!String.IsNullOrEmpty(model.F_JSZJ))
				{
				strSql.Append(" and F_JSZJ like @F_JSZJ ");
				MySqlParameter sq = new MySqlParameter("@F_JSZJ", MySqlDbType.String);           
				sq.Value =  "%"+model.F_JSZJ+"%";
				parameters.Add(sq);
				}
																				
																
								
				if(!String.IsNullOrEmpty(model.F_GNZJ))
				{
				strSql.Append(" and F_GNZJ like @F_GNZJ ");
				MySqlParameter sq = new MySqlParameter("@F_GNZJ", MySqlDbType.String);           
				sq.Value =  "%"+model.F_GNZJ+"%";
				parameters.Add(sq);
				}
																				
																
								
				if(!String.IsNullOrEmpty(model.GXSJ))
				{
				strSql.Append(" and GXSJ like @GXSJ ");
				MySqlParameter sq = new MySqlParameter("@GXSJ", MySqlDbType.String);           
				sq.Value =  "%"+model.GXSJ+"%";
				parameters.Add(sq);
				}
																				
												if(model.QYBZ!=null)
				{
				strSql.Append(" and QYBZ= @QYBZ ");
				MySqlParameter sq = new MySqlParameter("@QYBZ", MySqlDbType.Int32,8);
				sq.Value =  model.QYBZ;
				parameters.Add(sq);
				}
												
																				
							

			
           DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters.ToArray());
			List<UC_JSGNGXGLEntity> modelList=new List<UC_JSGNGXGLEntity>();
			
			   foreach (DataRow item in ds.Tables[0].Rows)
                {
			 		var temp = new UC_JSGNGXGLEntity();
                    DbHelperMySQL.DataRowToEntity<UC_JSGNGXGLEntity>(item, ref temp);
                    modelList.Add(temp);
				}				
			return modelList;
			}
            catch (Exception ex)
            {
               throw;
            }
		}
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int InsertUC_JSGNGXGL(UC_JSGNGXGLEntity model)
		{
		try{
		StringBuilder strSql1=new StringBuilder();
			strSql1.Append("insert into UC_JSGNGXGL(");	
		StringBuilder strSql2=new StringBuilder();
			strSql2.Append(") values (");		
			List<MySqlParameter> parameters = new List<MySqlParameter>();
														
									if(!String.IsNullOrEmpty(model.ZJ))
				{
				strSql1.Append("ZJ,");
				strSql2.Append("@ZJ,");
				MySqlParameter sq = new MySqlParameter("@ZJ", MySqlDbType.String);            
				sq.Value =  model.ZJ;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.F_JSZJ))
				{
				strSql1.Append("F_JSZJ,");
				strSql2.Append("@F_JSZJ,");
				MySqlParameter sq = new MySqlParameter("@F_JSZJ", MySqlDbType.String);            
				sq.Value =  model.F_JSZJ;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.F_GNZJ))
				{
				strSql1.Append("F_GNZJ,");
				strSql2.Append("@F_GNZJ,");
				MySqlParameter sq = new MySqlParameter("@F_GNZJ", MySqlDbType.String);            
				sq.Value =  model.F_GNZJ;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.GXSJ))
				{
				strSql1.Append("GXSJ,");
				strSql2.Append("@GXSJ,");
				MySqlParameter sq = new MySqlParameter("@GXSJ", MySqlDbType.String);            
				sq.Value =  model.GXSJ;
				parameters.Add(sq);
				}
																												if(model.QYBZ!=null)
				{
				strSql1.Append("QYBZ,");
				strSql2.Append("@QYBZ,");
				MySqlParameter sq = new MySqlParameter("@QYBZ", MySqlDbType.Int32,8);            
				sq.Value =  model.QYBZ;
				parameters.Add(sq);
				}
												
																							
		
		strSql1.Remove(strSql1.Length-1,1);
		strSql2.Remove(strSql2.Length-1,1);
		strSql2.Append(") ");   
		strSql1.Append(strSql2.ToString());
		
           return DbHelperMySQL.ExecuteSql(strSql1.ToString(),parameters.ToArray());	
            	}
            catch (Exception ex)
            {
               throw;
            }
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int UpdateUC_JSGNGXGL(UC_JSGNGXGLEntity model)
		{
		try{
		StringBuilder strSql=new StringBuilder();
			strSql.Append("update UC_JSGNGXGL set ");
		List<MySqlParameter> parameters = new List<MySqlParameter>();
														
									if(!String.IsNullOrEmpty(model.ZJ))
				{
				strSql.Append(" ZJ=@ZJ,");
				MySqlParameter sq = new MySqlParameter("@ZJ", MySqlDbType.String);            
				sq.Value =  model.ZJ;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.F_JSZJ))
				{
				strSql.Append(" F_JSZJ=@F_JSZJ,");
				MySqlParameter sq = new MySqlParameter("@F_JSZJ", MySqlDbType.String);            
				sq.Value =  model.F_JSZJ;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.F_GNZJ))
				{
				strSql.Append(" F_GNZJ=@F_GNZJ,");
				MySqlParameter sq = new MySqlParameter("@F_GNZJ", MySqlDbType.String);            
				sq.Value =  model.F_GNZJ;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.GXSJ))
				{
				strSql.Append(" GXSJ=@GXSJ,");
				MySqlParameter sq = new MySqlParameter("@GXSJ", MySqlDbType.String);            
				sq.Value =  model.GXSJ;
				parameters.Add(sq);
				}
																												if(model.QYBZ!=null)
				{
				strSql.Append(" QYBZ=@QYBZ,");
				MySqlParameter sq = new MySqlParameter("@QYBZ", MySqlDbType.Int32,8);            
				sq.Value =  model.QYBZ;
				parameters.Add(sq);
				}
												
																						
		
				strSql.Remove(strSql.Length-1,1);
				strSql.Append(" where ZJ = @ZJ");
            return DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters.ToArray());
				}
            catch (Exception ex)
            {
               throw;
            }
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int DeleteUC_JSGNGXGL(string guid)
		{
			try{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UC_JSGNGXGL ");
			strSql.Append(" where ZJ = @ZJ");
			 MySqlParameter[] parameters = {new MySqlParameter("@ZJ", MySqlDbType.VarChar,32)};           
			parameters[0].Value = guid;
			return DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
				}
            catch (Exception ex)
            {
               throw;
            }
		}
	}
}