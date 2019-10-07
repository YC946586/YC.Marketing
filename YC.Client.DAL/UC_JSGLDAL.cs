using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using YC.Client.Entity;
using MySql.Data.MySqlClient;
namespace YC.Client.DAL
{
	 	//UC_JSGL
		public partial class UC_JSGLDAL
	{
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public UC_JSGLEntity QueryUC_JSGLByGUID(string guid)
		{
			try{
				StringBuilder strSql=new StringBuilder();
				strSql.Append("select ZJ, JSMC, JSMS, CJSJ, GXSJ, BZ, QYBZ  ");			
				strSql.Append("  from UC_JSGL ");
				strSql.Append(" where ZJ = @ZJ");
				 MySqlParameter[] parameters = {new MySqlParameter("@ZJ", MySqlDbType.VarChar,32)};           
				parameters[0].Value = guid;
				UC_JSGLEntity model=new UC_JSGLEntity();
				DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			   foreach (DataRow item in ds.Tables[0].Rows)
                {
                    DbHelperMySQL.DataRowToEntity<UC_JSGLEntity>(item, ref model);
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
		public List<UC_JSGLEntity> ScreenUC_JSGL(UC_JSGLEntity model)
		{
		try{
		StringBuilder strSql=new StringBuilder();
			strSql.Append("select ZJ, JSMC, JSMS, CJSJ, GXSJ, BZ, QYBZ  ");			
			strSql.Append("  from UC_JSGL ");
			strSql.Append(" where 1=1 ");

				List<MySqlParameter> parameters = new List<MySqlParameter>();
																		
								
				if(!String.IsNullOrEmpty(model.ZJ))
				{
				strSql.Append(" and ZJ like @ZJ ");
				MySqlParameter sq = new MySqlParameter("@ZJ", MySqlDbType.String);           
				sq.Value =  "%"+model.ZJ+"%";
				parameters.Add(sq);
				}
																				
																
								
				if(!String.IsNullOrEmpty(model.JSMC))
				{
				strSql.Append(" and JSMC like @JSMC ");
				MySqlParameter sq = new MySqlParameter("@JSMC", MySqlDbType.String);           
				sq.Value =  "%"+model.JSMC+"%";
				parameters.Add(sq);
				}
																				
																
								
				if(!String.IsNullOrEmpty(model.JSMS))
				{
				strSql.Append(" and JSMS like @JSMS ");
				MySqlParameter sq = new MySqlParameter("@JSMS", MySqlDbType.String);           
				sq.Value =  "%"+model.JSMS+"%";
				parameters.Add(sq);
				}
																				
																
								
				if(!String.IsNullOrEmpty(model.CJSJ))
				{
				strSql.Append(" and CJSJ like @CJSJ ");
				MySqlParameter sq = new MySqlParameter("@CJSJ", MySqlDbType.String);           
				sq.Value =  "%"+model.CJSJ+"%";
				parameters.Add(sq);
				}
																				
																
								
				if(!String.IsNullOrEmpty(model.GXSJ))
				{
				strSql.Append(" and GXSJ like @GXSJ ");
				MySqlParameter sq = new MySqlParameter("@GXSJ", MySqlDbType.String);           
				sq.Value =  "%"+model.GXSJ+"%";
				parameters.Add(sq);
				}
																				
																
								
				if(!String.IsNullOrEmpty(model.BZ))
				{
				strSql.Append(" and BZ like @BZ ");
				MySqlParameter sq = new MySqlParameter("@BZ", MySqlDbType.String);           
				sq.Value =  "%"+model.BZ+"%";
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
			List<UC_JSGLEntity> modelList=new List<UC_JSGLEntity>();
			
			   foreach (DataRow item in ds.Tables[0].Rows)
                {
			 		var temp = new UC_JSGLEntity();
                    DbHelperMySQL.DataRowToEntity<UC_JSGLEntity>(item, ref temp);
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
		public int InsertUC_JSGL(UC_JSGLEntity model)
		{
		try{
		StringBuilder strSql1=new StringBuilder();
			strSql1.Append("insert into UC_JSGL(");	
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
																																
									if(!String.IsNullOrEmpty(model.JSMC))
				{
				strSql1.Append("JSMC,");
				strSql2.Append("@JSMC,");
				MySqlParameter sq = new MySqlParameter("@JSMC", MySqlDbType.String);            
				sq.Value =  model.JSMC;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.JSMS))
				{
				strSql1.Append("JSMS,");
				strSql2.Append("@JSMS,");
				MySqlParameter sq = new MySqlParameter("@JSMS", MySqlDbType.String);            
				sq.Value =  model.JSMS;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.CJSJ))
				{
				strSql1.Append("CJSJ,");
				strSql2.Append("@CJSJ,");
				MySqlParameter sq = new MySqlParameter("@CJSJ", MySqlDbType.String);            
				sq.Value =  model.CJSJ;
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
																																
									if(!String.IsNullOrEmpty(model.BZ))
				{
				strSql1.Append("BZ,");
				strSql2.Append("@BZ,");
				MySqlParameter sq = new MySqlParameter("@BZ", MySqlDbType.String);            
				sq.Value =  model.BZ;
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
		public int UpdateUC_JSGL(UC_JSGLEntity model)
		{
		try{
		StringBuilder strSql=new StringBuilder();
			strSql.Append("update UC_JSGL set ");
		List<MySqlParameter> parameters = new List<MySqlParameter>();
														
									if(!String.IsNullOrEmpty(model.ZJ))
				{
				strSql.Append(" ZJ=@ZJ,");
				MySqlParameter sq = new MySqlParameter("@ZJ", MySqlDbType.String);            
				sq.Value =  model.ZJ;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.JSMC))
				{
				strSql.Append(" JSMC=@JSMC,");
				MySqlParameter sq = new MySqlParameter("@JSMC", MySqlDbType.String);            
				sq.Value =  model.JSMC;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.JSMS))
				{
				strSql.Append(" JSMS=@JSMS,");
				MySqlParameter sq = new MySqlParameter("@JSMS", MySqlDbType.String);            
				sq.Value =  model.JSMS;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.CJSJ))
				{
				strSql.Append(" CJSJ=@CJSJ,");
				MySqlParameter sq = new MySqlParameter("@CJSJ", MySqlDbType.String);            
				sq.Value =  model.CJSJ;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.GXSJ))
				{
				strSql.Append(" GXSJ=@GXSJ,");
				MySqlParameter sq = new MySqlParameter("@GXSJ", MySqlDbType.String);            
				sq.Value =  model.GXSJ;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.BZ))
				{
				strSql.Append(" BZ=@BZ,");
				MySqlParameter sq = new MySqlParameter("@BZ", MySqlDbType.String);            
				sq.Value =  model.BZ;
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
		public int DeleteUC_JSGL(string guid)
		{
			try{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UC_JSGL ");
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