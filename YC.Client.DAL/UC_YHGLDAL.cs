using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using YC.Client.Entity;
using MySql.Data.MySqlClient;
namespace YC.Client.DAL
{
	 	//UC_YHGL
		public partial class UC_YHGLDAL
	{
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public UC_YHGLEntity QueryUC_YHGLByGUID(string guid)
		{
			try{
				StringBuilder strSql=new StringBuilder();
				strSql.Append("select ZJ_CSLJGL, LXBM, LXMC, SFLB, SFYXSC, LXMS, QYBZ  ");			
				strSql.Append("  from UC_YHGL ");
				strSql.Append(" where ZJ = @ZJ");
				 MySqlParameter[] parameters = {new MySqlParameter("@ZJ", MySqlDbType.VarChar,32)};           
				parameters[0].Value = guid;
				UC_YHGLEntity model=new UC_YHGLEntity();
				DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			   foreach (DataRow item in ds.Tables[0].Rows)
                {
                    DbHelperMySQL.DataRowToEntity<UC_YHGLEntity>(item, ref model);
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
		public List<UC_YHGLEntity> ScreenUC_YHGL(UC_YHGLEntity model)
		{
		try{
		StringBuilder strSql=new StringBuilder();
			strSql.Append("select ZJ_CSLJGL, LXBM, LXMC, SFLB, SFYXSC, LXMS, QYBZ  ");			
			strSql.Append("  from UC_YHGL ");
			strSql.Append(" where 1=1 ");

				List<MySqlParameter> parameters = new List<MySqlParameter>();
																		
								
				if(!String.IsNullOrEmpty(model.ZJ_CSLJGL))
				{
				strSql.Append(" and ZJ_CSLJGL like @ZJ_CSLJGL ");
				MySqlParameter sq = new MySqlParameter("@ZJ_CSLJGL", MySqlDbType.String);           
				sq.Value =  "%"+model.ZJ_CSLJGL+"%";
				parameters.Add(sq);
				}
																				
																
								
				if(!String.IsNullOrEmpty(model.LXBM))
				{
				strSql.Append(" and LXBM like @LXBM ");
				MySqlParameter sq = new MySqlParameter("@LXBM", MySqlDbType.String);           
				sq.Value =  "%"+model.LXBM+"%";
				parameters.Add(sq);
				}
																				
																
								
				if(!String.IsNullOrEmpty(model.LXMC))
				{
				strSql.Append(" and LXMC like @LXMC ");
				MySqlParameter sq = new MySqlParameter("@LXMC", MySqlDbType.String);           
				sq.Value =  "%"+model.LXMC+"%";
				parameters.Add(sq);
				}
																				
																
								
				if(!String.IsNullOrEmpty(model.SFLB))
				{
				strSql.Append(" and SFLB like @SFLB ");
				MySqlParameter sq = new MySqlParameter("@SFLB", MySqlDbType.String);           
				sq.Value =  "%"+model.SFLB+"%";
				parameters.Add(sq);
				}
																				
																
								
				if(!String.IsNullOrEmpty(model.SFYXSC))
				{
				strSql.Append(" and SFYXSC like @SFYXSC ");
				MySqlParameter sq = new MySqlParameter("@SFYXSC", MySqlDbType.String);           
				sq.Value =  "%"+model.SFYXSC+"%";
				parameters.Add(sq);
				}
																				
																
								
				if(!String.IsNullOrEmpty(model.LXMS))
				{
				strSql.Append(" and LXMS like @LXMS ");
				MySqlParameter sq = new MySqlParameter("@LXMS", MySqlDbType.String);           
				sq.Value =  "%"+model.LXMS+"%";
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
			List<UC_YHGLEntity> modelList=new List<UC_YHGLEntity>();
			
			   foreach (DataRow item in ds.Tables[0].Rows)
                {
			 		var temp = new UC_YHGLEntity();
                    DbHelperMySQL.DataRowToEntity<UC_YHGLEntity>(item, ref temp);
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
		public int InsertUC_YHGL(UC_YHGLEntity model)
		{
		try{
		StringBuilder strSql1=new StringBuilder();
			strSql1.Append("insert into UC_YHGL(");	
		StringBuilder strSql2=new StringBuilder();
			strSql2.Append(") values (");		
			List<MySqlParameter> parameters = new List<MySqlParameter>();
														
									if(!String.IsNullOrEmpty(model.ZJ_CSLJGL))
				{
				strSql1.Append("ZJ_CSLJGL,");
				strSql2.Append("@ZJ_CSLJGL,");
				MySqlParameter sq = new MySqlParameter("@ZJ_CSLJGL", MySqlDbType.String);            
				sq.Value =  model.ZJ_CSLJGL;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.LXBM))
				{
				strSql1.Append("LXBM,");
				strSql2.Append("@LXBM,");
				MySqlParameter sq = new MySqlParameter("@LXBM", MySqlDbType.String);            
				sq.Value =  model.LXBM;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.LXMC))
				{
				strSql1.Append("LXMC,");
				strSql2.Append("@LXMC,");
				MySqlParameter sq = new MySqlParameter("@LXMC", MySqlDbType.String);            
				sq.Value =  model.LXMC;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.SFLB))
				{
				strSql1.Append("SFLB,");
				strSql2.Append("@SFLB,");
				MySqlParameter sq = new MySqlParameter("@SFLB", MySqlDbType.String);            
				sq.Value =  model.SFLB;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.SFYXSC))
				{
				strSql1.Append("SFYXSC,");
				strSql2.Append("@SFYXSC,");
				MySqlParameter sq = new MySqlParameter("@SFYXSC", MySqlDbType.String);            
				sq.Value =  model.SFYXSC;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.LXMS))
				{
				strSql1.Append("LXMS,");
				strSql2.Append("@LXMS,");
				MySqlParameter sq = new MySqlParameter("@LXMS", MySqlDbType.String);            
				sq.Value =  model.LXMS;
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
		public int UpdateUC_YHGL(UC_YHGLEntity model)
		{
		try{
		StringBuilder strSql=new StringBuilder();
			strSql.Append("update UC_YHGL set ");
		List<MySqlParameter> parameters = new List<MySqlParameter>();
														
									if(!String.IsNullOrEmpty(model.ZJ_CSLJGL))
				{
				strSql.Append(" ZJ_CSLJGL=@ZJ_CSLJGL,");
				MySqlParameter sq = new MySqlParameter("@ZJ_CSLJGL", MySqlDbType.String);            
				sq.Value =  model.ZJ_CSLJGL;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.LXBM))
				{
				strSql.Append(" LXBM=@LXBM,");
				MySqlParameter sq = new MySqlParameter("@LXBM", MySqlDbType.String);            
				sq.Value =  model.LXBM;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.LXMC))
				{
				strSql.Append(" LXMC=@LXMC,");
				MySqlParameter sq = new MySqlParameter("@LXMC", MySqlDbType.String);            
				sq.Value =  model.LXMC;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.SFLB))
				{
				strSql.Append(" SFLB=@SFLB,");
				MySqlParameter sq = new MySqlParameter("@SFLB", MySqlDbType.String);            
				sq.Value =  model.SFLB;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.SFYXSC))
				{
				strSql.Append(" SFYXSC=@SFYXSC,");
				MySqlParameter sq = new MySqlParameter("@SFYXSC", MySqlDbType.String);            
				sq.Value =  model.SFYXSC;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.LXMS))
				{
				strSql.Append(" LXMS=@LXMS,");
				MySqlParameter sq = new MySqlParameter("@LXMS", MySqlDbType.String);            
				sq.Value =  model.LXMS;
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
		public int DeleteUC_YHGL(string guid)
		{
			try{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UC_YHGL ");
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