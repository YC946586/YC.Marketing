using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using YC.Client.Entity;
using MySql.Data.MySqlClient;
namespace YC.Client.DAL
{
	 	//UC_GNGL
		public partial class UC_GNGLDAL
	{
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public UC_GNGLEntity QueryUC_GNGLByGUID(string guid)
		{
			try{
				StringBuilder strSql=new StringBuilder();
				strSql.Append("select ZJ, JDMC, F_FJDZJ, GNBZ, VIPTYPE, SPACE, JDSX, CJSJ, QYBZ  ");			
				strSql.Append("  from UC_GNGL ");
				strSql.Append(" where ZJ = @ZJ");
				 MySqlParameter[] parameters = {new MySqlParameter("@ZJ", MySqlDbType.VarChar,32)};           
				parameters[0].Value = guid;
				UC_GNGLEntity model=new UC_GNGLEntity();
				DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			   foreach (DataRow item in ds.Tables[0].Rows)
                {
                    DbHelperMySQL.DataRowToEntity<UC_GNGLEntity>(item, ref model);
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
		public List<UC_GNGLEntity> ScreenUC_GNGL(UC_GNGLEntity model)
		{
		try{
		StringBuilder strSql=new StringBuilder();
			strSql.Append("select ZJ, JDMC, F_FJDZJ, GNBZ, VIPTYPE, SPACE, JDSX, CJSJ, QYBZ  ");			
			strSql.Append("  from UC_GNGL ");
			strSql.Append(" where 1=1 ");

				List<MySqlParameter> parameters = new List<MySqlParameter>();
																		
								
				if(!String.IsNullOrEmpty(model.ZJ))
				{
				strSql.Append(" and ZJ like @ZJ ");
				MySqlParameter sq = new MySqlParameter("@ZJ", MySqlDbType.String);           
				sq.Value =  "%"+model.ZJ+"%";
				parameters.Add(sq);
				}
																				
																
								
				if(!String.IsNullOrEmpty(model.JDMC))
				{
				strSql.Append(" and JDMC like @JDMC ");
				MySqlParameter sq = new MySqlParameter("@JDMC", MySqlDbType.String);           
				sq.Value =  "%"+model.JDMC+"%";
				parameters.Add(sq);
				}
																				
																
								
				if(!String.IsNullOrEmpty(model.F_FJDZJ))
				{
				strSql.Append(" and F_FJDZJ like @F_FJDZJ ");
				MySqlParameter sq = new MySqlParameter("@F_FJDZJ", MySqlDbType.String);           
				sq.Value =  "%"+model.F_FJDZJ+"%";
				parameters.Add(sq);
				}
																				
																
								
				if(!String.IsNullOrEmpty(model.GNBZ))
				{
				strSql.Append(" and GNBZ like @GNBZ ");
				MySqlParameter sq = new MySqlParameter("@GNBZ", MySqlDbType.String);           
				sq.Value =  "%"+model.GNBZ+"%";
				parameters.Add(sq);
				}
																				
																
								
				if(!String.IsNullOrEmpty(model.VIPTYPE))
				{
				strSql.Append(" and VIPTYPE like @VIPTYPE ");
				MySqlParameter sq = new MySqlParameter("@VIPTYPE", MySqlDbType.String);           
				sq.Value =  "%"+model.VIPTYPE+"%";
				parameters.Add(sq);
				}
																				
																
								
				if(!String.IsNullOrEmpty(model.SPACE))
				{
				strSql.Append(" and SPACE like @SPACE ");
				MySqlParameter sq = new MySqlParameter("@SPACE", MySqlDbType.String);           
				sq.Value =  "%"+model.SPACE+"%";
				parameters.Add(sq);
				}
																				
																
								
				if(!String.IsNullOrEmpty(model.JDSX))
				{
				strSql.Append(" and JDSX like @JDSX ");
				MySqlParameter sq = new MySqlParameter("@JDSX", MySqlDbType.String);           
				sq.Value =  "%"+model.JDSX+"%";
				parameters.Add(sq);
				}
																				
																
								
				if(!String.IsNullOrEmpty(model.CJSJ))
				{
				strSql.Append(" and CJSJ like @CJSJ ");
				MySqlParameter sq = new MySqlParameter("@CJSJ", MySqlDbType.String);           
				sq.Value =  "%"+model.CJSJ+"%";
				parameters.Add(sq);
				}
																				
																
								
				if(!String.IsNullOrEmpty(model.QYBZ))
				{
				strSql.Append(" and QYBZ like @QYBZ ");
				MySqlParameter sq = new MySqlParameter("@QYBZ", MySqlDbType.String);           
				sq.Value =  "%"+model.QYBZ+"%";
				parameters.Add(sq);
				}
																				
							

			
           DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters.ToArray());
			List<UC_GNGLEntity> modelList=new List<UC_GNGLEntity>();
			
			   foreach (DataRow item in ds.Tables[0].Rows)
                {
			 		var temp = new UC_GNGLEntity();
                    DbHelperMySQL.DataRowToEntity<UC_GNGLEntity>(item, ref temp);
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
		public int InsertUC_GNGL(UC_GNGLEntity model)
		{
		try{
		StringBuilder strSql1=new StringBuilder();
			strSql1.Append("insert into UC_GNGL(");	
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
																																
									if(!String.IsNullOrEmpty(model.JDMC))
				{
				strSql1.Append("JDMC,");
				strSql2.Append("@JDMC,");
				MySqlParameter sq = new MySqlParameter("@JDMC", MySqlDbType.String);            
				sq.Value =  model.JDMC;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.F_FJDZJ))
				{
				strSql1.Append("F_FJDZJ,");
				strSql2.Append("@F_FJDZJ,");
				MySqlParameter sq = new MySqlParameter("@F_FJDZJ", MySqlDbType.String);            
				sq.Value =  model.F_FJDZJ;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.GNBZ))
				{
				strSql1.Append("GNBZ,");
				strSql2.Append("@GNBZ,");
				MySqlParameter sq = new MySqlParameter("@GNBZ", MySqlDbType.String);            
				sq.Value =  model.GNBZ;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.VIPTYPE))
				{
				strSql1.Append("VIPTYPE,");
				strSql2.Append("@VIPTYPE,");
				MySqlParameter sq = new MySqlParameter("@VIPTYPE", MySqlDbType.String);            
				sq.Value =  model.VIPTYPE;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.SPACE))
				{
				strSql1.Append("SPACE,");
				strSql2.Append("@SPACE,");
				MySqlParameter sq = new MySqlParameter("@SPACE", MySqlDbType.String);            
				sq.Value =  model.SPACE;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.JDSX))
				{
				strSql1.Append("JDSX,");
				strSql2.Append("@JDSX,");
				MySqlParameter sq = new MySqlParameter("@JDSX", MySqlDbType.String);            
				sq.Value =  model.JDSX;
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
																																
									if(!String.IsNullOrEmpty(model.QYBZ))
				{
				strSql1.Append("QYBZ,");
				strSql2.Append("@QYBZ,");
				MySqlParameter sq = new MySqlParameter("@QYBZ", MySqlDbType.String);            
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
		public int UpdateUC_GNGL(UC_GNGLEntity model)
		{
		try{
		StringBuilder strSql=new StringBuilder();
			strSql.Append("update UC_GNGL set ");
		List<MySqlParameter> parameters = new List<MySqlParameter>();
														
									if(!String.IsNullOrEmpty(model.ZJ))
				{
				strSql.Append(" ZJ=@ZJ,");
				MySqlParameter sq = new MySqlParameter("@ZJ", MySqlDbType.String);            
				sq.Value =  model.ZJ;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.JDMC))
				{
				strSql.Append(" JDMC=@JDMC,");
				MySqlParameter sq = new MySqlParameter("@JDMC", MySqlDbType.String);            
				sq.Value =  model.JDMC;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.F_FJDZJ))
				{
				strSql.Append(" F_FJDZJ=@F_FJDZJ,");
				MySqlParameter sq = new MySqlParameter("@F_FJDZJ", MySqlDbType.String);            
				sq.Value =  model.F_FJDZJ;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.GNBZ))
				{
				strSql.Append(" GNBZ=@GNBZ,");
				MySqlParameter sq = new MySqlParameter("@GNBZ", MySqlDbType.String);            
				sq.Value =  model.GNBZ;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.VIPTYPE))
				{
				strSql.Append(" VIPTYPE=@VIPTYPE,");
				MySqlParameter sq = new MySqlParameter("@VIPTYPE", MySqlDbType.String);            
				sq.Value =  model.VIPTYPE;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.SPACE))
				{
				strSql.Append(" SPACE=@SPACE,");
				MySqlParameter sq = new MySqlParameter("@SPACE", MySqlDbType.String);            
				sq.Value =  model.SPACE;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.JDSX))
				{
				strSql.Append(" JDSX=@JDSX,");
				MySqlParameter sq = new MySqlParameter("@JDSX", MySqlDbType.String);            
				sq.Value =  model.JDSX;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.CJSJ))
				{
				strSql.Append(" CJSJ=@CJSJ,");
				MySqlParameter sq = new MySqlParameter("@CJSJ", MySqlDbType.String);            
				sq.Value =  model.CJSJ;
				parameters.Add(sq);
				}
																																
									if(!String.IsNullOrEmpty(model.QYBZ))
				{
				strSql.Append(" QYBZ=@QYBZ,");
				MySqlParameter sq = new MySqlParameter("@QYBZ", MySqlDbType.String);            
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
		public int DeleteUC_GNGL(string guid)
		{
			try{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UC_GNGL ");
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