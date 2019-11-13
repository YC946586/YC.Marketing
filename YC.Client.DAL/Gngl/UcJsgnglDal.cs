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
    [Data("YC.Client.Entity.Gngl.UcJsgnglEntity")]
    public partial class UcJsgnglDal : IUsDataDal<UcJsgnglEntity>
    {

        public bool Exists(string ZJ)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from uc_jsgngl");
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
        public void Add(UcJsgnglEntity model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into uc_jsgngl(");
            strSql.Append("ZJ,ZJ_JSGL,ZJ_GNGL,GNMC,BZ,QYBZ");
            strSql.Append(") values (");
            strSql.Append("@ZJ,@ZJ_JSGL,@ZJ_GNGL,@GNMC,@BZ,@QYBZ");
            strSql.Append(") ");

            SQLiteParameter[] parameters = {
                        new SQLiteParameter("@ZJ", DbType.String) ,
                        new SQLiteParameter("@ZJ_JSGL", DbType.String) ,
                        new SQLiteParameter("@ZJ_GNGL", DbType.String) ,
                        new SQLiteParameter("@GNMC", DbType.String) ,
                        new SQLiteParameter("@BZ", DbType.String) ,
                        new SQLiteParameter("@QYBZ", DbType.Int32,8)

            };

            parameters[0].Value = model.ZJ;
            parameters[1].Value = model.ZJ_JSGL;
            parameters[2].Value = model.ZJ_GNGL;
            parameters[3].Value = model.GNMC;
            parameters[4].Value = model.BZ;
            parameters[5].Value = model.QYBZ;
            DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(UcJsgnglEntity model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update uc_jsgngl set ");

            strSql.Append(" ZJ = @ZJ , ");
            strSql.Append(" ZJ_JSGL = @ZJ_JSGL , ");
            strSql.Append(" ZJ_GNGL = @ZJ_GNGL , ");
            strSql.Append(" GNMC = @GNMC , ");
            strSql.Append(" BZ = @BZ , ");
            strSql.Append(" QYBZ = @QYBZ  ");
            strSql.Append(" where ZJ=@ZJ  ");

            SQLiteParameter[] parameters = {
                        new SQLiteParameter("@ZJ", DbType.String) ,
                        new SQLiteParameter("@ZJ_JSGL", DbType.String) ,
                        new SQLiteParameter("@ZJ_GNGL", DbType.String) ,
                        new SQLiteParameter("@GNMC", DbType.String) ,
                        new SQLiteParameter("@BZ", DbType.String) ,
                        new SQLiteParameter("@QYBZ", DbType.Int32,8)

            };

            parameters[0].Value = model.ZJ;
            parameters[1].Value = model.ZJ_JSGL;
            parameters[2].Value = model.ZJ_GNGL;
            parameters[3].Value = model.GNMC;
            parameters[4].Value = model.BZ;
            parameters[5].Value = model.QYBZ;
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
            strSql.Append("delete from uc_jsgngl ");
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
        public UcJsgnglEntity GetModel(string ZJ)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ZJ, ZJ_JSGL, ZJ_GNGL, GNMC, BZ, QYBZ  ");
            strSql.Append("  from uc_jsgngl ");
            strSql.Append(" where ZJ=@ZJ ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ZJ", DbType.String)           };
            parameters[0].Value = ZJ;


            UcJsgnglEntity model = new UcJsgnglEntity();
            DataSet ds = DbHelperSQLite.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                model.ZJ = ds.Tables[0].Rows[0]["ZJ"].ToString();
                model.ZJ_JSGL = ds.Tables[0].Rows[0]["ZJ_JSGL"].ToString();
                model.ZJ_GNGL = ds.Tables[0].Rows[0]["ZJ_GNGL"].ToString();
                model.GNMC = ds.Tables[0].Rows[0]["GNMC"].ToString();
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
            strSql.Append(" FROM uc_jsgngl ");
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
            strSql.Append(" FROM uc_jsgngl ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQLite.Query(strSql.ToString());
        }

        public DataSet Addition(UcJsgnglEntity model)
        {
            throw new NotImplementedException();
        }
    }
}
