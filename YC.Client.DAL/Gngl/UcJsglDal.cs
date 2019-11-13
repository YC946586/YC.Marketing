using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YC.Client.Entity;

namespace YC.Client.Data.Gngl
{
    //uc_jsgl
    [Data("YC.Client.Entity.Gngl.UcJsglEntity")]
    public partial class UcJsglDal : IUsDataDal<UcJsglEntity>
    {

        public bool Exists(string ZJ)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from uc_jsgl");
            strSql.Append(" where ");
            strSql.Append(" ZJ = @ZJ  ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ZJ", DbType.String)           };
            parameters[0].Value = ZJ;

            return DbHelperSQLite.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(UcJsglEntity model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into uc_jsgl(");
            strSql.Append("ZJ,JSMC,JSLX,CJR,CJSJ,BZ,QYBZ");
            strSql.Append(") values (");
            strSql.Append("@ZJ,@JSMC,@JSLX,@CJR,@CJSJ,@BZ,@QYBZ");
            strSql.Append(") ");

            SQLiteParameter[] parameters = {
                        new SQLiteParameter("@ZJ", DbType.String) ,
                        new SQLiteParameter("@JSMC", DbType.String) ,
                        new SQLiteParameter("@JSLX", DbType.String) ,
                        new SQLiteParameter("@CJR", DbType.String) ,
                        new SQLiteParameter("@CJSJ", DbType.String) ,
                        new SQLiteParameter("@BZ", DbType.String) ,
                        new SQLiteParameter("@QYBZ", DbType.Int32,8)

            };

            parameters[0].Value = model.ZJ;
            parameters[1].Value = model.JSMC;
            parameters[2].Value = model.JSLX;
            parameters[3].Value = model.CJR;
            parameters[4].Value = model.CJSJ;
            parameters[5].Value = model.BZ;
            parameters[6].Value = model.QYBZ;
            DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(UcJsglEntity model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update uc_jsgl set ");

            strSql.Append(" ZJ = @ZJ , ");
            strSql.Append(" JSMC = @JSMC , ");
            strSql.Append(" JSLX = @JSLX , ");
            strSql.Append(" CJR = @CJR , ");
            strSql.Append(" CJSJ = @CJSJ , ");
            strSql.Append(" BZ = @BZ , ");
            strSql.Append(" QYBZ = @QYBZ  ");
            strSql.Append(" where ZJ=@ZJ  ");

            SQLiteParameter[] parameters = {
                        new SQLiteParameter("@ZJ", DbType.String) ,
                        new SQLiteParameter("@JSMC", DbType.String) ,
                        new SQLiteParameter("@JSLX", DbType.String) ,
                        new SQLiteParameter("@CJR", DbType.String) ,
                        new SQLiteParameter("@CJSJ", DbType.String) ,
                        new SQLiteParameter("@BZ", DbType.String) ,
                        new SQLiteParameter("@QYBZ", DbType.Int32,8)

            };

            parameters[0].Value = model.ZJ;
            parameters[1].Value = model.JSMC;
            parameters[2].Value = model.JSLX;
            parameters[3].Value = model.CJR;
            parameters[4].Value = model.CJSJ;
            parameters[5].Value = model.BZ;
            parameters[6].Value = model.QYBZ;
            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string ZJ)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from uc_jsgl ");
            strSql.Append(" where ZJ=@ZJ ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ZJ", DbType.String)           };
            parameters[0].Value = ZJ;


            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public UcJsglEntity GetModel(string ZJ)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ZJ, JSMC, JSLX, CJR, CJSJ, BZ, QYBZ  ");
            strSql.Append("  from uc_jsgl ");
            strSql.Append(" where ZJ=@ZJ ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ZJ", DbType.String)           };
            parameters[0].Value = ZJ;


            UcJsglEntity model = new UcJsglEntity();
            DataSet ds = DbHelperSQLite.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                model.ZJ = ds.Tables[0].Rows[0]["ZJ"].ToString();
                model.JSMC = ds.Tables[0].Rows[0]["JSMC"].ToString();
                model.JSLX = ds.Tables[0].Rows[0]["JSLX"].ToString();
                model.CJR = ds.Tables[0].Rows[0]["CJR"].ToString();
                model.CJSJ = ds.Tables[0].Rows[0]["CJSJ"].ToString();
                model.BZ = ds.Tables[0].Rows[0]["BZ"].ToString();
                if (ds.Tables[0].Rows[0]["QYBZ"].ToString() != "")
                {
                    model.QYBZ = int.Parse(ds.Tables[0].Rows[0]["QYBZ"].ToString());
                }

                return model;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM uc_jsgl ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQLite.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" FROM uc_jsgl ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQLite.Query(strSql.ToString());
        }

        public DataSet Addition(UcJsglEntity model)
        {
            throw new NotImplementedException();
        }
    }
}
